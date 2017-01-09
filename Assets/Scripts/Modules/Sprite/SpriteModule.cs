/*
 * Author(s): Isaiah Mann
 * Description: Loads sprites for the game from resources
 * Usage: [no notes]
 */

using UnityEngine;
using System.Collections.Generic;

public class SpriteModule : Module 
{	
	const string TILES_SUFFIX = "Tile";

	Dictionary<string, Sprite> spriteLookup = new Dictionary<string, Sprite>();

	public Sprite GetTile(TileType type)
	{
		string fileName = getTileFileName(type);
		// Debug.Log(fileName);
		Sprite tileSprite;
		if(spriteLookup.TryGetValue(fileName, out tileSprite))
		{
			return tileSprite;
		}
		else
		{
			tileSprite = loadSpriteFromResources(fileName);
			return addSpriteToLookup(fileName, tileSprite);
		}
	}

	Sprite addSpriteToLookup(string fileName, Sprite sprite)
	{
		spriteLookup.Add(fileName, sprite);
		return sprite;
	}

	Sprite loadSpriteFromResources(string fileName)
	{
		return Resources.Load<Sprite>(spritePath(fileName));
	}

	string getTileFileName(TileType type)
	{
		return string.Format("{0}{1}", type.TileName, TILES_SUFFIX);
	}
}
