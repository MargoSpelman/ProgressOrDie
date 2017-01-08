/*
 * Author(s): Isaiah Mann
 * Description: Loads sprites for the game from resources
 * Usage: [no notes]
 */

using UnityEngine;
using System.Collections.Generic;

public class SpriteModule : Module 
{	
	Dictionary<string, Sprite> tileSpriteLookup = new Dictionary<string, Sprite>();

	public Sprite GetTile(TileType type)
	{
		throw new System.NotImplementedException();
	}

}
