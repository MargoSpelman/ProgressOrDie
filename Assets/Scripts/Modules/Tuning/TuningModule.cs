/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

public class TuningModule : Module
{
	public int MaxRange {
		get {
			return data.MaxRange;
		}
	}

	TuningData data;

	public void Init (TuningData data) {
		this.data = data;
	}
}

[System.Serializable]
public class TuningData : SerializableData
{
	public int MaxRange;
}
