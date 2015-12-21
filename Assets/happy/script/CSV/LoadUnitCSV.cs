using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class LoadUnitCSV : CSV {
	// ユニットのデータ格納用リスト
	private List<string[]> unitDataList = new List<string[]>();

	public override void CSVRead (string readFileName){
		TextAsset csv = Resources.Load("CSV/" + readFileName) as TextAsset;
		StringReader reader = new StringReader(csv.text);

		while (reader.Peek() > -1) {
			string line = reader.ReadLine();
			string[] values = line.Split(',');
			Debug.Log (line);
			if(values[0] == "UnitName"){
				continue;
			}else{
				// データの格納
				unitDataList.Add (values);
			}	
		}
	}

	public List<string[]> UnitList{
		get{ return unitDataList;}
	}
}
