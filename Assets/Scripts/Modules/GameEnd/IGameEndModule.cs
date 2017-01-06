/*
 * Authors: Isaiah Mann
 * Description: An interface to end of game logic
 */

public interface IGameEndModule {

	void ProcessGameEnd(IGameSave gameProgress, GameEndType endType);

	bool PlayerEarnedLegend(IGameSave gameProgress, GameEndType endType);
	IPlayerLegend GetLegendEarned(IGameSave gameProgress, GameEndType endType);
	void GivePlayerLegend (IGameSave gameprogress, GameEndType endType);

}
