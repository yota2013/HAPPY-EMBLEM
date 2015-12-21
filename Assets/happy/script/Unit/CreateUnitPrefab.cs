using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateUnitPrefab : MonoBehaviour {

	// Unitプレハブの指定
	public GameObject Unit;

	private SetUnitStatus setUnitStatus;
	private LoadUnitCSV loadUnitCSV;

	// インスタンス生成
	void Awake() {
		loadUnitCSV = new LoadUnitCSV();
	}

	// Use this for initialization
	void Start() {
		setUnitStatus = this.gameObject.GetComponent<SetUnitStatus> ();

		loadUnitCSV.CSVRead ("TestUnitData");
		CreatePrefab (loadUnitCSV.UnitList);
	}

	public void CreatePrefab(List<string[]> unitDataList) {
		// 生成する最初の場所
		Vector2 initialPos = new Vector2 ();

		// 
		if(unitDataList != null){
			for(int i = 0; i < unitDataList.Count; i++){
				initialPos.x = (float)int.Parse(unitDataList[i][5]);
				initialPos.y = (float)int.Parse(unitDataList[i][6]);

				GameObject createdUnit = (GameObject)Instantiate (	Unit, 
																	initialPos,
																	Quaternion.identity	);

				setUnitStatus.UnitStatusSet(unitDataList[i], createdUnit);
			}
		}
		Destroy (this.gameObject);
	}
}
