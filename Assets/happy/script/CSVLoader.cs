using UnityEngine;
using System.Collections;
using System.IO;

public class CSVLoader : MonoBehaviour{

	void Start() {
		Debug.Log ("start");
		CSVLoad ("TestUnitData");
	}

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
				UnitStatusSetter (values);
			}
		}
	}

	public void UnitStatusSetter(string[] values) {
		UnitStatus unitStatus = this.gameObject.GetComponent<UnitStatus> ();

		unitStatus.Name = values [0];
		unitStatus.Type = values [1];
		unitStatus.AP 	= int.Parse(values [2]);
		unitStatus.HP 	= int.Parse(values [3]);
		unitStatus.DP 	= int.Parse(values [4]);
	}
}