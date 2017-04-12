using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TrophySetter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = GlobalTrophies.score + "";
	}

	// Update is called once per frame
	void Update () {

	}
}