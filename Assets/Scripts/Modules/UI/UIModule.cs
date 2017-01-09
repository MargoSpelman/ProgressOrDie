/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

using UnityEngine;

public class UIModule : Module, IUIModule
{	
	[SerializeField]
	UIElement turnText;
	[SerializeField]
	UIButton endTurnButton;

	public void Init(TurnModule turn) {
		turnText.SetText(turn.CurrentTurnStr());
		turn.SubscribeToTurnSwitchStr(handleTurnChange);
		endTurnButton.SubscribeToClick(turn.NextTurn);
	}

	void handleTurnChange (string turnName) {
		turnText.SetText(turnName);
	}
}
