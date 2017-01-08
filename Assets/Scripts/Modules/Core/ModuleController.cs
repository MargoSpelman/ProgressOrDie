/*
 * Author: Isaiah Mann
 * Desc: Handles controller all the modules
 */

using UnityEngine;

public class ModuleController : SingletonController<ModuleController> {
	[SerializeField]
	ParserModule parser;

	[SerializeField]
	AudioModule sound;

	[SerializeField]
	EventModule events;

	EnemyData enemyData;
	TileData tileData;

	protected override void SetReferences ()
	{
		base.SetReferences ();
		enemyData = parser.ParseFromResources<EnemyData>("JSON/Enemies");
		tileData = parser.ParseFromResources<TileData>("JSON/Tiles");
	}
		
}
