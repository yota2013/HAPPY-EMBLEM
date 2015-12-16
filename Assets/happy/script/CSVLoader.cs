using UnityEngine;
using System.Collections;
using System.IO;

public class CSVLoader {

	/*
	void Start() {
		Debug.Log ("start");
		CSVLoad ("TestUnitData");
	}
	*/

	public void CSVLoad(string filename){
		TextAsset csv = Resources.Load("CSV/" + filename) as TextAsset;
		StringReader reader = new StringReader(csv.text);

		while (reader.Peek() > -1) {
			string line = reader.ReadLine();
			string[] values = line.Split(',');
			Debug.Log (line);
			if(values[0] == "UnitName"){
				continue;
			}else{
				//UnitStatusSetter (values);
				Generate(values);
			}
		}
	}

	// 生成処理
	public abstract void Generate(string []values){
	}
}