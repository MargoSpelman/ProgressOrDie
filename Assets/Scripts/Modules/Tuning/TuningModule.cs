/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

using UnityEngine;

public class TuningModule : Module
{
	public int MaxRange {
		get {
			return data.MaxRange;
		}
	}

	public float BulkToHPRatio { 
		get {
			return data.BulkToHPRatio;
		}
	}

	public int MaxSpeed {
		get {
			return data.MaxSpeed;
		}
	}

	public int DamagePerMagicPoint {
		get {
			return data.DamagePerMagicPoint;
		}
	}

	public int DamagePerStrengthPoint {
		get {
			return data.DamagePerStrengthPoint;
		}
	}

	public int MaxSkill {
		get {
			return data.MaxSkill;
		}
	}

	public float CriticalHitRatePerSkillPoint {
		get {
			return data.CriticalHitRatePerSkillPoint;
		}
	}

	public int StartingHealthPotions {
		get {
			return data.StartingHealthPotions;
		}
	}

	public int VisionRange {
		get {
			return data.VisionRange;
		}
	}

	public float CriticalHitDamageMod {
		get {
			return data.CriticalHitDamageMod;
		}
	}

	TuningData data;

	public void Init (TuningData data) {
		this.data = data;
	}

	public int GetMeleeDamage (IUnit unit) {
		return unit.GetStrength() * DamagePerStrengthPoint;
	}

	public int GetMagicDamage (IUnit unit) {
		return unit.GetMagic() * DamagePerMagicPoint;
	}

	public bool CriticalHit (IUnit unit) {
		float critChance = CriticalHitRatePerSkillPoint * unit.GetSkill();
		return Random.Range(0.0f, 1.0f) < critChance;
	}
}

[System.Serializable]
public class TuningData : SerializableData
{
	public int MaxRange;
	public float BulkToHPRatio;
	public int MaxSpeed;
	public int DamagePerMagicPoint;
	public int DamagePerStrengthPoint;
	public int MaxSkill;
	public float CriticalHitRatePerSkillPoint;
	public int StartingHealthPotions;
	public int VisionRange;
	public float CriticalHitDamageMod;

}
