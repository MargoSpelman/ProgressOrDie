/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

using System.Collections.Generic;
using UnityEngine;

public class UnitModule : Module 
{	
	PlayerCharacterBehaviour mainPlayer;

	[SerializeField]
	PlayerCharacterBehaviour playerPrefab;
	[SerializeField]
	EnemyNPCBehaviour enemyPrefab;
	
	const string PLAYER_KEY = "P";
	List<Unit> units = new List<Unit>();

	public void Init(MapModule map, 
		SpriteModule sprites, 
		string[,] units,
		EnemyData enemyInfo,
		TurnModule turns,
		MovementModule movement,
		CombatModule combat, 
		StatModule stats,
		AbilitiesModule abilities
	){
		createUnits(map.Map, units, enemyInfo);
		placeUnits(map, sprites, this.units.ToArray(), turns, movement, combat, stats, abilities);

	}

	public PlayerCharacterBehaviour GetMainPlayer () {
		return this.mainPlayer;
	}

	void createUnits(Map map, string[,] units, EnemyData enemyInfo) {
		Dictionary<string, EnemyDescriptor> lookup = getEnemyLookup(enemyInfo);
		for (int x = 0; x < map.Width; x++) {	
			for (int y = 0; y < map.Width; y++) {
				string tileUnit = units[x, y];
				if (isUnit(tileUnit)) {
					MapLocation startLocation = new MapLocation(x, y);
					if(isPlayer(tileUnit)) {
						this.units.Add(new PlayerCharacter(startLocation, map));
					} else {
						EnemyDescriptor descr;
						if(lookup.TryGetValue(tileUnit, out descr)) {
							this.units.Add(new EnemyNPC(descr, startLocation, map));
						}
					}
				}
			}
		}
	}

	void placeUnits(MapModule map, 
		SpriteModule sprites, 
		Unit[] units, 
		TurnModule turns,
		MovementModule movement, 
		CombatModule combat,
		StatModule stats,
		AbilitiesModule abilities
	) {
		
		for (int i = 0; i < units.Length; i++) {
			Agent agent;
			Unit unit = units[i];
			if (unit is PlayerCharacter) {
				agent = getPlayer(unit as PlayerCharacter);
				mainPlayer = agent as PlayerCharacterBehaviour;
			} else if (unit is EnemyNPC) {
				agent = getEnemy(unit as EnemyNPC, sprites);
			} else {
				// Skip this unit: it's not supported
				continue;
			}
			agent.Init(turns, movement, combat, stats, abilities);
			map.PlaceUnit(agent);
		}

	}
		
	EnemyNPCBehaviour getEnemy (EnemyNPC data, SpriteModule sprites) {
		EnemyNPCBehaviour enemy = Instantiate(enemyPrefab, transform);	
		enemy.SetEnemy(data);
		enemy.SetSprite(sprites.GetEnemy(data.Descriptor));
		return enemy;
	}

	PlayerCharacterBehaviour getPlayer (PlayerCharacter data) {
		PlayerCharacterBehaviour player = Instantiate(playerPrefab, transform);	
		player.SetCharacter(data);
		return player;
	}

	bool isUnit(string unitKey) {
		return !string.IsNullOrEmpty(unitKey);
	}

	bool isPlayer(string unitKey) {
		return unitKey.Equals(PLAYER_KEY);
	}

	Dictionary<string, EnemyDescriptor> getEnemyLookup (EnemyData enemyInfo) {
		Dictionary<string, EnemyDescriptor> lookup = new Dictionary<string, EnemyDescriptor>();
		foreach (EnemyDescriptor descriptor in enemyInfo.Enemies) {
			lookup.Add(descriptor.Key, descriptor);
		}
		return lookup;
	}
}
