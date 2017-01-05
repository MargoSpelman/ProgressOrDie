/*
 * Author: Isaiah Mann
 * Desc: A single cell on the map
 */

public interface IMapTile {

	bool IsOccupiedByUnit();

	int GetX();
	int GetY();

	TerrainType GetTerrain();

}
