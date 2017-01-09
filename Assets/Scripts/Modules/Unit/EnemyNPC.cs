/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

public class EnemyNPC : Unit, IEnemyNPC
{
	public EnemyDescriptor Descriptor{get; private set;}

	public EnemyNPC(EnemyDescriptor descriptor, MapLocation location, Map map) :
	base (location, map) {
		this.Descriptor = descriptor;
	}

	public int GetSpeed () {
		return Descriptor.Speed;
	}

	public int GetConstitution () {
		return Descriptor.Constitution;
	}

	public int GetSkill () {
		return Descriptor.Skill;
	}

	public int GetStrength () {
		return Descriptor.Strength;
	}

	public int GetMagic () {
		return Descriptor.Magic;
	}
		
}
