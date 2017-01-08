/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

public class MapTile : WorldData, IMapTile
{
	MapLocation location;
	IUnit occupyingUnit;
	TileType type;

	public MapTile(int x, int y, TileType type)
	{
		this.location = new MapLocation(x, y);
		this.type = type;
	}

	public bool IsOccupiedByUnit()
	{
		return occupyingUnit != null;
	}

	public int GetX()
	{
		return this.location.X;
	}

	public int GetY()
	{
		return this.location.Y;
	}

	public MapLocation GetLocation()
	{
		return this.location;
	}

	public TileType GetTileType()
	{
		return this.type;
	}

	public void PlaceUnit(IUnit unit)
	{
		this.occupyingUnit = unit;
	}

	public void RemoveUnit()
	{
		this.occupyingUnit = null;
	}

}
