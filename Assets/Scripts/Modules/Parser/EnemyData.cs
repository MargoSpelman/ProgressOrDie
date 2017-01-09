/*
 * Author(s): Isaiah Mann
 * Description: [to be added]
 * Usage: [no notes]
 */

[System.Serializable]
public class EnemyData : SerializableData
{
	public EnemyDescriptor[] Enemies;
	public StatPrefix[] Prefxies;
}

[System.Serializable]
public class EnemyDescriptor : SerializableData
{
	public string Names;
	public string[] Types;
	public int Speed;
	public int Strength;
	public int Skill;
	public int Constitution;
	public int Magic;
	public int[] Size;
	public int TurnPriority;
}


[System.Serializable]
public class StatPrefix
{
	public string Prefix;
	public string Stat;
}
