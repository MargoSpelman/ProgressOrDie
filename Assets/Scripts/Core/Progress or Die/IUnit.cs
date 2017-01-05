/*
 * Author: Isaiah Mann
 * Desc: An interface to define a Unit
 */

public interface IUnit {

	int GetSpeed();
	int GetConstitution();
	int GetMagic();
	int GetStrength();
	int GetSkill();

	IMapTile GetLocation();

	TerrainType GetCurrentTerrain();
	AttackType[] GetAvailableAttacks();

	bool CanMoveTo (IMapTile tile);
	bool CanAttack (IUnit unit, AttackType attack);
	bool CanMeleeAttack (IUnit unit);
	bool CanMagicAttack (IUnit unit);

	void MoveTo (IMapTile tile);
	void Attack (IUnit unit);
	void Attack(IUnit unit, AttackType attack);
	void MeleeAttack(IUnit unit);
	void MagicAttack(IUnit unit);
	void Kill ();

}
