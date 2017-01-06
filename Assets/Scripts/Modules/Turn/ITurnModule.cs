public interface ITurnModule { 

	void SwitchToMnstrTurn();

	bool CheckIfMnstrAttacked(IUnit monster);

	bool CheckForLastMnstr(IUnit monster);

	void SwitchToPlayerTurn();

	int SwapToNextMnsTurn(IUnit monster, int numMonster);
}
