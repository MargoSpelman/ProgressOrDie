/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

public class MovementModule : Module
{
	TurnModule turn;

	public void Init (TurnModule turn) {
		this.turn = turn;
	}

	public bool CanMove (Agent agent) {
		return agent.GetAgentType() == turn.GetCurrentTurn();
	}
}
