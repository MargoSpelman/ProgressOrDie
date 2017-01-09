/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

using UnityEngine;

public class PlayerCharacterBehaviour : PlayerAgent 
{	
	PlayerCharacter character;

	public override Unit GetUnit() {
		return character;
	}

	public void SetCharacter (PlayerCharacter character) {
		this.character = character;
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

}
