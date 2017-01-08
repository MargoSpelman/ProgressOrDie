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

	[SerializeField]
	SpriteModule sprites;

	EnemyData enemyData;
	TileData tileData;

	protected override void SetReferences ()
	{
		base.SetReferences ();
		enemyData = parser.ParseJSONFromResources<EnemyData>("Enemies");
		tileData = parser.ParseJSONFromResources<TileData>("Tiles");
	}
		
}
