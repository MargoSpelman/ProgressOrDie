using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixpanelScript : MonoBehaviour {

	/*/set this to the distinct ID /*/
	public string Token;
	public string DistinctID;


	// Use this for initialization
	public void Start () { 

		Mixpanel.Token = Token;
		Mixpanel.DistinctID = DistinctID;

		/*/ Set this to the distinct ID of the current user/*/


	


	

		Mixpanel.Token= "1b6f1caa2d59c490c189621be1ea58e3";
		Mixpanel.DistinctID = "the distinct ID string of your user";
		/*//*/
		using mixpanel;

		Mixpanel.Track()



		Mixpanel.SendEvent("Restart Button");
		Mixpanel.SendEvent("Consumed Health Potion");
		Mixedpanel.SendEvent("Click Target", {"monster", string "meelee/strength attack", "monster", string "ranged attack,);
		Mixedpanel.SendEvent("Click Ability");
		Mixedpanel.SendEvent("Death",{"player", string "death", 


		Mixpanel.SuperProperties.Add("platform", Application.platform.ToString());
		Mixpanel.SuperProperties.Add("quality", QualitySettings.names[QualitySettings.GetQualityLevel()]);
		Mixpanel.SuperProperties.Add("fullscreen", Screen.fullScreen);
		Mixpanel.SuperProperties.Add("resolution", Screen.width + "x" + Screen.height);



		/*/Timing Events /*/ 
			Mixpanel.StartTimedEvent("Meelee/Strength Attack Button");
			Mixedpanel.StartTimedEvent("Ranged/Magic Button");
			Mixedpanel.StartTimedEvent("Movement Overlay");
			Mixedpanel.StartTimedEvent("Consumed Health Potions");
			Mixedpanel.StartTimedEvent("Click Target");
			Mixedpanel.StartTimedEvent("Click Ability");
			Mixedpanel.StartTimedEvent("Allocate Stat points");
			Mixedpanel.StartTimedEvent("Restart button");
			Mixedpanel.StartTimedEvent("Arrows to increase stats");
				
			}

			public void OnGUI() {
				if(GUILayout.Button("Send Event"))
				{
					Mixpanel.SendEvent(_eventName, new Dictionary<string, object>
						{
							{"property1", _property1},
							{"property2", _property2},
						});
				}
			}

	}

		

	
	// Update is called once per frame
	void Update () {
		
	}
}
