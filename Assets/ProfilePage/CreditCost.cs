using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;
using UnityEngine.UI;

public class CreditCost : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int currPrize = Int32.Parse (GetComponent<Text> ().text) - 1;

		GetComponent<Text> ().text = GlobalVariables.Prizes[currPrize] + " - " + GlobalVariables.Costs [currPrize] + " Credits";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
