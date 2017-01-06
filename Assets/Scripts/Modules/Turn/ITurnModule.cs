/*
 * Authors: Xijie Guo
 * Description: An interface to handle the turn logic
 */

public interface ITurnModule { 

	void SwitchToMnsterTurn();

	bool CheckMonsterAttack(IUnit monster, IUnit player);

	bool CheckForLastMon(IUnit monster, IUnit player);

	void SwitchToPlayerTurn();

	int updateMonster(IUnit monster, int numMonster);
}
