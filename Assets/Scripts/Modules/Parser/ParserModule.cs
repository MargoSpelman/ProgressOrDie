/*
 * Author(s): Isaiah Mann
 * Desc:
 */

using UnityEngine;

public class ParserModule : Module, IParserModule {

	public T ParseFromResources<T> (string path) {
		string json = getTextAssetInResources(path).text;
		return Parse<T>(json);
	}

	public T Parse<T> (string json) {
		return JsonUtility.FromJson<T>(json);
	}

	TextAsset getTextAssetInResources (string path) {
		return Resources.Load<TextAsset>(path);
	}

}
