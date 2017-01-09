/*
 * Author(s): Isaiah Mann 
 * Description: A single event class that others can subscribe to and call events from
 * Currently relies on event names as strings
 * Event method can be overloaded to implement different event types
 */

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EventModule : Module, IEventModule {

	public static EventModule Instance {get; private set;}
	public static bool HasInstance {
		get {
			return Instance != null;
		}
	}

	#region Event Types

	public delegate void NamedEventAction (string nameOfEvent);
	public event NamedEventAction OnNamedEvent;

	public delegate void NamedFloatAction (string valueKey, float key);
	public event NamedFloatAction OnNamedFloatEvent;

    public delegate void AudioEventAction(AudioActionType actionType, AudioType audioType);
    public event AudioEventAction OnAudioEvent;

	#endregion

	#region MonoBehaviourExtended Overrides

	protected override void SetReferences () {
		base.SetReferences ();
		Instance = this;
	}

	#endregion

	#region Instance Event Calls

	public void InstanceEvent (string eventName) {
		if (OnNamedEvent != null) {
			OnNamedEvent(eventName);
		}
	}

	public void InstanceEvent (string valueKey, float value) {
		if (OnNamedFloatEvent != null) {
			OnNamedFloatEvent(valueKey, value);
		}
	}

	public void InstanceEvent(AudioActionType actionType, AudioType audioType) {
		if (OnAudioEvent != null) {
			OnAudioEvent(actionType, audioType);
		}
	}

	#endregion

	#region Instance Event Subscription

	public void InstanceSubscribe (NamedEventAction action) {
		OnNamedEvent += action;
	}

	public void InstanceSubscribe (NamedFloatAction action) {
		OnNamedFloatEvent += action;
	}

	public void InstanceSubscribe (AudioEventAction action) {
		OnAudioEvent += action;
	}

	public void InstanceUnsubscribe (NamedEventAction action) {
		OnNamedEvent -= action;
	}

	public void InstanceUnsubscribe (NamedFloatAction action) {
		OnNamedFloatEvent -= action;
	}

	public void InstanceUnsubscribe (AudioEventAction action) {
		OnAudioEvent -= action;
	}

	#endregion

	#region Static Event Calls

	public static void Event (string eventName) {
		if (HasInstance) {
			Instance.InstanceEvent(eventName);
		}
	}

	public static void Event (string valueKey, float value) {
		if (HasInstance) {
			Instance.InstanceEvent(valueKey, value);
		}
	}

    public static void Event(AudioActionType actionType, AudioType audioType) {
		if (HasInstance) {
			Instance.InstanceEvent(actionType, audioType);
		}
    }

	#endregion

	#region Static Event Subscription

	public static void Subscribe (NamedEventAction action) {
		if (HasInstance) {
			Instance.InstanceSubscribe(action);
		}
	}

	public static void Subscribe (NamedFloatAction action) {
		if (HasInstance) {
			Instance.InstanceSubscribe(action);
		}
	}

	public static void Subscribe (AudioEventAction action) {
		if (HasInstance) {
			Instance.InstanceSubscribe(action);
		}
	}

	public static void Unsubscribe (NamedEventAction action) {
		if (HasInstance) {
			Instance.InstanceUnsubscribe(action);
		}
	}

	public static void Unsubscribe (NamedFloatAction action) {
		if (HasInstance) {
			Instance.InstanceUnsubscribe(action);
		}
	}

	public static void Unsubscribe (AudioEventAction action) {
		if (HasInstance) {
			Instance.InstanceUnsubscribe(action);
		}
	}

	#endregion

}