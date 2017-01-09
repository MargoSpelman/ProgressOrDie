/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

public class EnemyNPCBehaviour : AIAgent 
{	
	EnemyNPC enemy;

	public override Unit GetUnit() {
		return enemy;
	}

	public void SetEnemy (EnemyNPC enemy) {
		this.enemy = enemy;
	}
}
