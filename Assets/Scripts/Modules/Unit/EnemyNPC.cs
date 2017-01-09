/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

using UnityEngine.UI;

public class EnemyNPC : Unit, IEnemyNPC
{
	public EnemyDescriptor Descriptor{get; private set;}

	public EnemyNPC(UnitModule parent, EnemyDescriptor descriptor, MapLocation location, Map map) :
	base (parent, location, map) {
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
