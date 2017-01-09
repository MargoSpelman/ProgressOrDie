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

	public int Width {
		get {
			return tiles.GetLength(0);
		}
	}

	public int Height {
		get {
			return tiles.GetLength(1);
		}
	}

	MapTile[,] tiles;

	public bool CoordinateIsInBounds (int x, int y) {
		return IntUtil.InRange(x, Width) && IntUtil.InRange(y, Height);
	}

	public MapTile GetTile (int x, int y) {
		if (CoordinateIsInBounds(x, y)) {
			return tiles[x, y];
		} else {
			return MapTile.Default;
		}
	}

	public MapTile GetTile (MapLocation loc) {
		return GetTile(loc.X, loc.Y);
	}
}
