/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

using UnityEngine;
using System.Collections.Generic;

public class MapModule : Module, IMapModule 
{	
	Map map;

	public void Init(string[,] tiles, TileType[] tileTypes) {
		this.map = new Map(parseTilesToMap(tiles, tileTypes));
	}

	MapTile[,] parseTilesToMap(string[,] tileKeys, TileType[] tileTypes) {
		int width = tileKeys.GetLength(0);
		int height = tileKeys.GetLength(1);
		Dictionary<string, TileType> tileLookup = getTileLookup(tileTypes);
		MapTile[,] tiles = new MapTile[width, height];
		for (int x = 0; x < width; x++) {
			for (int y = 0; y < height; y++) {
				tiles[x, y] = new MapTile(x, y, tileLookup[tileKeys[x, y]]);
			}
		}
		return tiles;
	}

	Dictionary<string, TileType> getTileLookup(TileType[] tileTypes) {
		Dictionary<string, TileType> tileLookup = new Dictionary<string, TileType>();
		foreach (TileType tile in tileTypes) {
			tileLookup.Add(tile.Key, tile);
		}
		return tileLookup;
	}
		
	public bool CoordinateIsInBounds (int x, int y) {
		return map.CoordinateIsInBounds(x, y);
	}

	public IMapTile GetTile (int x, int y) {
		return map.GetTile(x, y);
	}

}
