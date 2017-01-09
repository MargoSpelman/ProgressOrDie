/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

public class MovementModule : Module
{
	AgentAction onAgentMove;
	TurnModule turn;

	void callOnAgentMove (Agent agent) {
		if (onAgentMove != null) {
			onAgentMove(agent);
		}
	}
		
	public void SubscribeToAgentMove (AgentAction action) {
		onAgentMove += action;
	}

	public void UnsubscribeFromAgentMove (AgentAction action) {
		onAgentMove -= action;
	}

	public void Init (TurnModule turn) {
		this.turn = turn;
	}

	public bool CanMove (Agent agent) {
		return agent.GetAgentType() == turn.GetCurrentTurn();
	}

	public void Move (Agent agent) {
		callOnAgentMove(agent);
	}
}
