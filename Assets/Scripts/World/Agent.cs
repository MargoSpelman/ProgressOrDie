/*
 * Author(s): Isaiah Mann
 * Description: Super class for all agents operating in the game world
 */

using UnityEngine;
using System.Collections;

public abstract class Agent : MobileObjectBehaviour {
	SpriteRenderer spriteR;

	public bool HasUnit {
		get {
			return GetUnit() != null;
		}
	}

	protected Map map {
		get {
			return GetUnit().Map;
		}
	}

	protected MapLocation currentLoc {
		get {
			return GetUnit().GetLocation();
		}
	}

	protected override void SetReferences()
	{
		base.SetReferences();
		spriteR = GetComponent<SpriteRenderer>();
	}

	public void SetSprite(Sprite sprite) {
		this.spriteR.sprite = sprite;
	}

	public MapLocation GetStartLocation() {
		return GetUnit().StartingLocation;
	}

	public virtual Unit GetUnit () {
		// Overriden in subclass
		return null;
	}

	public void SetLocation(MapTileBehaviour tile) {
		this.GetUnit().SetTile(tile.Tile);
		SetPos(tile.WorldPos());
	}

	public void SetPos(Vector3 pos) {
		this.transform.position = pos;
	}
		
	public bool MoveX(int dir) { 
		MapLocation newLoc = currentLoc.Translate(dir, 0);
		if (map.CoordinateIsInBounds(newLoc)) {
			map.TravelTo(this, newLoc);
			return true;
		} else {
			return false;
		}
	}

	public bool MoveY(int dir) {
		MapLocation newLoc = currentLoc.Translate(0, dir);
		if (map.CoordinateIsInBounds(newLoc)) {
			map.TravelTo(this, newLoc);
			return true;
		} else {
			return false;
		}
	}

}
