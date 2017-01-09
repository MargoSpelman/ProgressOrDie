/*
 * Author(s): Isaiah Mann
 * Description: Super class for all agents operating in the game world
 */

using System;
using UnityEngine;
using System.Collections;

public abstract class Agent : MobileObjectBehaviour {
	SpriteRenderer spriteR;

	protected MovementModule movement;
	protected CombatModule combat;
	protected StatModule stats;
	protected AbilitiesModule abilities;

	public abstract AgentType GetAgentType();

	public void Init (
		MovementModule movement,
		CombatModule combat,
		StatModule stats,
		AbilitiesModule abilities
	){
		this.movement = movement;
		this.combat = combat;
		this.stats = stats;
		this.abilities = abilities;
	}

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
		return move(dir, 0);
	}

	public bool MoveY(int dir) {
		return move(0, dir);
	}

	protected bool move (int deltaX, int deltaY) {
		if (movement.CanMove(this)) {
			MapLocation newLoc = currentLoc.Translate(deltaX, deltaY);
			if (map.CoordinateIsInBounds(newLoc)) {
				map.TravelTo(this, newLoc);
				return true;
			} else {
				return false;
			}
		} else {
			return false;
		}
	}

	public static int AgentTypeCount () {
		return Enum.GetNames(typeof(AgentType)).Length;
	}
}

public enum AgentType {
	Player,
	Enemy,
}