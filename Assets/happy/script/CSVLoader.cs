using UnityEngine;
using System.Collections;
using System.IO;

public class CSVLoader : MonoBehaviour {

	public void CSVLoad(string filePath){
		TextAsset csv = Resources.Load(filePath) as TextAsset;
		StringReader reader = new StringReader(csv.text);
		while (reader.Peek() > -1) {
			string line = reader.ReadLine();
			string[] values = line.Split(',');
		}
	}
}