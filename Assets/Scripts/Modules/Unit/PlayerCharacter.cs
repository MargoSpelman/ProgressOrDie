/*
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

	public PlayerCharacter(MapLocation location) : base (location) {

	}

	public int GetSpeed () {
		return speed;
	}

	public int GetMagic () {
		return magic;
	}

	public int GetConstitution () {
		return constitution;
	}

	public int GetStrength () {
		return strength;
	}

	public int GetSkill () {
		return skill;
	}
}
