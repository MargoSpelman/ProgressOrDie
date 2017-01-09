/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

public class CombatModule : Module
{
	UnitModule units;
	MapModule map;
	AbilitiesModule abilities;
	StatModule stats;
	GameEndModule gameEnd;

	public void Init (
		UnitModule units, 
		MapModule map, 
		AbilitiesModule abilities,
		StatModule stats,
		GameEndModule gameEnd
	)
	{
		this.units = units;
		this.map = map;
		this.abilities = abilities;
		this.stats = stats;
		this.gameEnd = gameEnd;
	}
}
