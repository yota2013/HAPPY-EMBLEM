using UnityEngine;
using System.Collections;

public class SetUnitStatus : MonoBehaviour {

	public void UnitStatusSet(string[] values, GameObject Unit) {
		
		UnitStatus unitStatus = Unit.GetComponent<UnitStatus> ();

		unitStatus.Name = values [0];
		unitStatus.Type = values [1];
		unitStatus.AP 	= int.Parse(values [2]);
		unitStatus.HP 	= int.Parse(values [3]);
		unitStatus.DP 	= int.Parse(values [4]);
	}
}
