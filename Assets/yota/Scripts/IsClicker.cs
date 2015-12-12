using UnityEngine;
using System.Collections;

public class IsClicker : MonoBehaviour {

	// Use this for initializatio
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			Debug.Log ("A key or mouse click has been detected");
			//Fader fader = gameObject.GetComponent<Fader>();
			Fader.instance.WhiteIn(1f, () => gameObject.SetActive(false));
			gameObject.GetComponent<FadeMoveScene> ().MoveScene ("SceneSelect",2.0f);
			}
	}
}
