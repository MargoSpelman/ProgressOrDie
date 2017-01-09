/*
 * Author(s): Isaiah Mann
 * Desc:
 */

using UnityEngine;

public class ParserModule : Module, IParserModule {

	public T ParseJSONFromResources<T> (string fileName) {
		string json = getTextAssetInResources(jsonPath(fileName)).text;
		return ParseJSON<T>(json);
	}

	public T ParseJSON<T> (string json) {
		return JsonUtility.FromJson<T>(json);
	}

	public string[,] ParseCSVFromResources (string fileName) {
		throw new System.NotImplementedException();
	}

	public string[,] ParseCSV (string csv) {
		throw new System.NotImplementedException();
	}

	TextAsset getTextAssetInResources (string path) {
		return Resources.Load<TextAsset>(path);
	}

}
