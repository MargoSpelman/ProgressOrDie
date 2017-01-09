/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

public class PlayerCharacterBehaviour : PlayerAgent 
{	
	PlayerCharacter character;

	public override Unit GetUnit() {
		return character;
	}

	public void SetCharacter (PlayerCharacter character) {
		this.character = character;
	}
}
