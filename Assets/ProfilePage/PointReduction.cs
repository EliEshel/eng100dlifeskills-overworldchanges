using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class PointReduction : MonoBehaviour {

	// Use this for initialization
	public void Adjust () {
		GlobalCredits.credits -= Int32.Parse(GlobalVariables.Costs[GlobalVariables.dialog - 1]);
	}
}
