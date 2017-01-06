/*
 * Authors: Ian Macpherson, Isaiah Mann
 * Description: An interface to handle the combat logic
 */

public interface ICombatModule {

	bool IsTargetInRange (IUnit attacker, IUnit target);

	bool IsTargetAdjacent (IUnit unit);

	void MeleeAttack (IUnit unit);

	void RangedAttack (IUnit unit);

	void FleeAttempt (IStatModule playerstats, IUnit unit);

	void KillUnit (IUnit unit);
}
