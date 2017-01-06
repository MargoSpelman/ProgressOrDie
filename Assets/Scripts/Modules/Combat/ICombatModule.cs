/*
 * Authors: Ian Macpherson, Isaiah Mann
 * Description: An interface to handle the combat logic
 */

public interface ICombatModule {

	bool IsTargetInRange (IUnit unit);

	bool IsTargetAdjacent (IUnit unit);

	void MeleeAttack (IUnit unit);

	void RangedAttack (IUnit unit);

	void FleeAttempt (IStatModule playerstats, IUnit unit);

	void KillMonster (IUnit unit);
}
