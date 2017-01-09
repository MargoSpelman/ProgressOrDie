/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

public class EnemyNPC : Unit, IEnemyNPC
{
	EnemyDescriptor descriptor;


	public int GetSpeed () {
		return descriptor.Speed;
	}

	public int GetConstitution () {
		return descriptor.Constitution;
	}

	public int GetSkill () {
		return descriptor.Skill;
	}

	public int GetStrength () {
		return descriptor.Strength;
	}

	public int GetMagic () {
		return descriptor.Magic;
	}
		
}
