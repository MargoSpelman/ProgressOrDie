/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

using UnityEngine;

public class MapTileBehaviour : WorldObjectBehaviour 
{	
	public bool HasAgent {
		get {
			return containedAgent != null;
		}
	}

	Agent containedAgent;
	SpriteRenderer spriteR;
	Map map;
	MapTile tile;

	protected override void SetReferences () {
		base.SetReferences ();
		this.spriteR = GetComponent<SpriteRenderer>();
	}

	public void SetTile (Map map, MapTile tile, Sprite sprite) {
		this.map = map;
		this.tile = tile;
		tile.Link(this);
		transform.position = getPosition();
		spriteR.sprite = sprite;
	}

	public void PlaceUnit(Agent agent) {
		this.containedAgent = agent;
		agent.SetPos(transform.position);
	}
		
	Vector3 getPosition() {
		return new Vector3((float) (tile.GetX() - map.Width / 2) / 4f, (float) (tile.GetY() - map.Height / 2) / 4f);
	}
}
