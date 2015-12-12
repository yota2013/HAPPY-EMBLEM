using UnityEngine;
using System.Collections;

public class UnitStatus : MonoBehaviour {

	//
	// ユニットのパラメータ
	//

	private string UnitName;		// 名前
	private string UnitType;		// ユニットの役職
	private int attackPoint;        // 攻撃力
	private int defensePoint;       // 防御力
	//private int movingDistance;     // 移動距離(要変更)
	private int hitPoint;           // 体力


	//
	// 以下プロパティ
	//

	public string Name {
		get { return UnitName; }
		set { UnitName = value; }
	}

	public string Type {
		get { return UnitType; }
		set { UnitType = value; }
	}

	public int AP {
		get { return attackPoint; }
		set { attackPoint = value; }
	}

	public int DP {
		get { return defensePoint; }
		set { defensePoint = value; }
	}

	// 移動に関する場所、あとで要変更
	//public int MD {
	//	get { return movingDistance; }
	//	set { movingDistance = value; }
	//}

	public int HP {
		get { return hitPoint; }
		set { hitPoint = value; }
	}

}
