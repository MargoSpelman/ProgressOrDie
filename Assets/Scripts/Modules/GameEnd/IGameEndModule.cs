/*
 * Authors: Isaiah Mann
 * Description: An interface to end of game logic
 */

public interface IGameEndModule {

	void ProcessGameEnd(IPlayerCharacter player, GameEndType endType);

}
