/*
 * Author(s): Isaiah Mann
 * Description: Map of the game world
 * Usage: [no notes]
 */

public class Map 
{
	public Map(MapTile[,] tiles) {
		this.tiles = tiles;
	}

	int width {
		get {
			return tiles.GetLength(0);
		}
	}

	int height {
		get {
			return tiles.GetLength(1);
		}
	}

	MapTile[,] tiles;

	public bool CoordinateIsInBounds (int x, int y) {
		return IntUtil.InRange(x, width) && IntUtil.InRange(y, height);
	}

	public IMapTile GetTile (int x, int y) {
		if (CoordinateIsInBounds(x, y)) {
			return tiles[x, y];
		} else {
			return MapTile.Default;
		}
	}
}
