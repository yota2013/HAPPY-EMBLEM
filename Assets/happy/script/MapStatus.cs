using UnityEngine;
using System.Collections;

public class MapStatus : MonoBehaviour {

	private int movingCost;

	public string Cost {
		get { return movingCost; }
		set { movingCost= value; }
	}

}
