using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreditSetter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = "Credits: " + GlobalCredits.credits;
	}

	// Update is called once per frame
	void Update () {
		GetComponent<Text> ().text = "Credits: " + GlobalCredits.credits;
	}
}