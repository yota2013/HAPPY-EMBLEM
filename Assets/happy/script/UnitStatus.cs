using UnityEngine;
using System.Collections;

public class UnitStatus : MonoBehaviour {

	//
	// ユニットのパラメータ
	//

	private int attackPoint;        // 攻撃力
	private int defensePoint;       // 防御力
	private int movingDistance;     // 移動距離
	private int hitPoint;           // 体力


	//
	// 以下プロパティ
	//

	public int AP {
		get { return attackPoint; }
		set { attackPoint = value; }
	}

	public int DP {
		get { return defensePoint; }
		set { defensePoint = value; }
	}

	public int MD {
		get { return movingDistance; }
		set { movingDistance = value; }
	}

	public int HP {
		get { return hitPoint; }
		set { hitPoint = value; }
	}

}
