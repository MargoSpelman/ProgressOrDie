/*
 * Author(s): Isaiah Mann
 * Desc: Parses json into C# Classes
 */

public interface IParserModule {

	T ParseFromResources<T> (string pathInResources);
	T Parse<T> (string json);

}
