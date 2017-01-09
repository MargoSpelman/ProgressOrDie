/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

public class StatModule : Module
{
	TuningModule tuning;

	public void Init (TuningModule tuning) {
		this.tuning = tuning;
	}

	public float BulkToHPRatio {
		get {
			return tuning.BulkToHPRatio;
		}
	}

	public int MaxRange {
		get {
			return tuning.MaxRange;
		}
	}
}
