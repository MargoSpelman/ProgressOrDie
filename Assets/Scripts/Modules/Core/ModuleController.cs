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

	[SerializeField]
	MapModule map;

	[SerializeField]
	UnitModule unit;

	[SerializeField]
	UIModule ui;

	[SerializeField]
	CameraModule cam;

	protected override void SetReferences ()
	{
		base.SetReferences ();
		EnemyData enemyData = parser.ParseJSONFromResources<EnemyData>("Enemies");
		TileData tileData = parser.ParseJSONFromResources<TileData>("Tiles");
		string[,] tiles = parser.ParseCSVFromResources("Example/Tiles");
		map.Init(tiles, tileData.Tiles, sprites);
		string[,] units = parser.ParseCSVFromResources("Example/Units");
		unit.Init(map, sprites, units, enemyData);
		cam.StartFollowing(unit.GetMainPlayer());
	}
		
}
