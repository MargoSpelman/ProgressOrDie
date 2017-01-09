/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

public class Unit
{
	public Map Map{get; private set;}
	public MapLocation StartingLocation {get; private set;}

	public Unit(MapLocation location, Map map) {
		this.StartingLocation = location;
		this.Map = map;
	}

	MapTile occupiedTile;
	public void SetTile (MapTile tile) {
		this.occupiedTile = tile;
	}

	public MapLocation GetLocation () {
		return this.occupiedTile.GetLocation();
	}

	public AttackType[] GetAvailableAttacks() {
		throw new System.NotImplementedException();
	}

	public bool CanMoveTo (IMapTile tile) {
		throw new System.NotImplementedException();
	}

	public bool CanAttack (IUnit unit, AttackType attack) {
		throw new System.NotImplementedException();
	}

	public bool CanMeleeAttack (IUnit unit) {
		throw new System.NotImplementedException();
	}

	public bool CanMagicAttack (IUnit unit) {
		throw new System.NotImplementedException();
	}

	public void MoveTo (IMapTile tile) {
		throw new System.NotImplementedException();
	}

	public void Attack (IUnit unit) {
		throw new System.NotImplementedException();
	}

	public void Attack(IUnit unit, AttackType attack) {
		throw new System.NotImplementedException();
	}

	public void MeleeAttack(IUnit unit) {
		throw new System.NotImplementedException();
	}

	public void MagicAttack(IUnit unit) {
		throw new System.NotImplementedException();
	}

	public void Kill () {
		throw new System.NotImplementedException();
	}
}
