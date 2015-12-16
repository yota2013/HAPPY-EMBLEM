using UnityEngine;
using System.Collections;

public class GenerateUnitObject : MonoBehaviour, CSVLoader{

	// Unitプレハブの指定
	public GameObject Unit;

	private SetUnitStatus setUnitStatus;


	// 将来的にはStart内でUnitプレハブをロードしておく
	// 現状は簡単にできるようにpublic変数に
	// Inspectorから指定しておくことにする
	void Start() {
		setUnitStatus = this.gameObject.GetComponent<SetUnitStatus> ();
		CSVLoader.CSVLoad ("TestUnitData");
	}

	// Unitプレハブをこのメソッドで生成
	public override void Generate(string[] values){

		// プレハブをシーン内に生成
		GameObject generatedUnit = Instantiate (Unit, 
												new Vector2 (int.Parse (values [5]), int.Parse (values [6])),
												Quaternion.identity);

		// 値をセットする
		// 処理はSetUnitStatusコンポーネントに任せてます
		setUnitStatus.UnitStatusSet(values, generatedUnit);
	}
}
