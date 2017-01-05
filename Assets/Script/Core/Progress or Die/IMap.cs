/*
 * Author: Isaiah Mann
 * Desc: Represents the entire map
 */

public interface IMap {

	bool CoordinateIsInBounds (int x, int y);

	IMapTile GetTile (int x, int y);

	TerrainType GetTerrainTypeOfTile (int x, int y);

}
