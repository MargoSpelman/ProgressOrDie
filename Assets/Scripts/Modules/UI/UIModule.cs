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
	[Space(25)]
	[SerializeField]
	UIFillBar strengthBar;
	[SerializeField]
	UIFillBar skillBar;
	[SerializeField]
	UIFillBar magicBar;
	[SerializeField]
	UIFillBar constitutionBar;
	[SerializeField]
	UIFillBar speedBar;
	[Space(25)]
	[SerializeField]
	UIFillBar critBar;

	PlayerCharacterBehaviour playerAgent;
	PlayerCharacter playerUnit;

	public void Init(TurnModule turn, UnitModule units) {
		turnText.SetText(turn.CurrentTurnStr());
		turn.SubscribeToTurnSwitchStr(handleTurnChange);
		endTurnButton.SubscribeToClick(turn.NextTurn);
		this.playerAgent = units.GetMainPlayer();
		this.playerAgent.SubscribeToAgilityChange(handleAgilityChange);
		this.playerUnit = playerAgent.GetUnit() as PlayerCharacter;
	}

	void handleAgilityChange(float newAgility) {
		speedBar.HandleUpdateFillValue(newAgility);
		speedBar.HandleUpdateFill(newAgility / (float) playerUnit.GetSpeed());
	}

	void handleTurnChange (string turnName) {
		turnText.SetText(turnName);
	}
}
