using UnityEngine;
using System.Collections;

public class GlobalCredits : MonoBehaviour {

	public static int credits = GlobalScore.score/100;

	// Use this for initialization
	void Awake () {

		GlobalCredits.credits = GlobalScore.score/100;

	}

	// Update is called once per frame
	void Update () {
		if (GlobalScore.score > GlobalCredits.credits) {
			GlobalCredits.credits = GlobalScore.score/100;
		}

	}
}