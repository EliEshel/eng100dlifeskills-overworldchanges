using UnityEngine;
using System.Collections;

public class GlobalTrophies : MonoBehaviour {

	public static int score = 1;

	// Use this for initialization
	void Awake () {

		GlobalTrophies.score = 1;

	}

	// Update is called once per frame
	void Update () {


	}

	public static void addScore(int num) {



		GlobalScore.score+=num;

	}

	public static int getScore() {

		return GlobalScore.score;

	}
}