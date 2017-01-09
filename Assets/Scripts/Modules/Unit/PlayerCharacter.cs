﻿/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

public class PlayerCharacter : Unit, IPlayerCharacter
{
	int speed;
	int magic;
	int constitution;
	int strength;
	int skill;

	public PlayerCharacter(MapLocation location, Map map) : 
	base (location, map) {
		setStatsToDefault();
	}

	void setStatsToDefault () {
		speed = 9;
		magic = 9;
		constitution = 9;
		strength = 9;
		skill = 9;
	}
		
	public override int GetSpeed () {
		return speed;
	}

	public override int GetMagic () {
		return magic;
	}

	public override int GetConstitution () {
		return constitution;
	}

	public override int GetStrength () {
		return strength;
	}

	public override int GetSkill () {
		return skill;
	}
}
