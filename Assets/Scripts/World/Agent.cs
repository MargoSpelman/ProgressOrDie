/*
 * Author(s): Isaiah Mann
 * Description: Super class for all agents operating in the game world
 */

using UnityEngine;
using System.Collections;

public abstract class Agent : MobileObjectBehaviour {
	public bool HasUnit {
		get {
			return GetUnit() != null;
		}
	}

	public MapLocation GetStartLocation() {
		return GetUnit().StartingLocation;
	}

	public virtual Unit GetUnit () {
		return null;
	}

	public void SetPos(Vector3 pos) {
		this.transform.position = pos;
	}
}
