/*
 * Author: Isaiah Mann
 * Desc: An interface to define a Unit
 */

public interface IUnit {

	bool CanMoveTo (IMapTile tile);
	bool CanAttack (IUnit unit);

	void MoveTo (IMapTile tile);
	void Attack (IUnit unit);
	void Kill ();

}
