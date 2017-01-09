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

	public override int GetSpeed () {
		return Descriptor.Speed;
	}

	public override int GetConstitution () {
		return Descriptor.Constitution;
	}

	public override  int GetSkill () {
		return Descriptor.Skill;
	}

	public override int GetStrength () {
		return Descriptor.Strength;
	}

	public override int GetMagic () {
		return Descriptor.Magic;
	}
}
