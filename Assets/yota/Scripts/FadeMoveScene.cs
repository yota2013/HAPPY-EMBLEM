using UnityEngine;
using System.Collections;

public class FadeMoveScene : MonoBehaviour {
	public void MoveScene(string SceneName,float time)
	{
		FadeManager.Instance.LoadLevel (SceneName,time);
	}

}
