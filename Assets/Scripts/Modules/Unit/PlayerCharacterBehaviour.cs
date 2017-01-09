/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

using UnityEngine;

public class PlayerCharacterBehaviour : PlayerAgent 
{	
	MonoActionf onAgilityChange;

	PlayerCharacter character;

	public override AgentType GetAgentType()
	{
		return AgentType.Player;
	}

	public override Unit GetUnit() {
		return GetCharacter();
	}

	public PlayerCharacter GetCharacter () {
		return character;
	}

	public void SetCharacter (PlayerCharacter character) {
		this.character = character;
		this.character.LinkToAgent(this);
		ReplenishAgility(AgentType.Player);
	}

	public void SubscribeToAgilityChange (MonoActionf action) {
		onAgilityChange += action;
	}

	public void UnsubscribeFromAgilityChange (MonoActionf action) {
		onAgilityChange -= action;
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.W)) {
			MoveY(1);
		} else if (Input.GetKeyDown(KeyCode.S)) {
			MoveY(-1);
		}
		if (Input.GetKeyDown(KeyCode.A)) {
			MoveX(-1);
		} else if (Input.GetKeyDown(KeyCode.D)) {
			MoveX(1);
		}
	}

	public override bool ReplenishAgility(AgentType type)
	{
		if (base.ReplenishAgility(type)) {
			callAgilityChange(remainingAgilityForTurn);
			return true;
		} else {
			return false;
		}
	}

	protected override bool trySpendAgility(int agilityPointsReq)
	{
		if (base.trySpendAgility(agilityPointsReq)) {
			callAgilityChange(remainingAgilityForTurn);
			return true;
		} else {
			return false;
		}
	}

	void callAgilityChange (float agility) {
		if (onAgilityChange != null) {
			onAgilityChange(agility);
		}
	}

}
