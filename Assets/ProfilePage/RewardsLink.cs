using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardsLink : MonoBehaviour {

	// Use this for initialization
	public void ChangeScene(string SceneName) {
		Application.LoadLevel(SceneName);
	}

}
