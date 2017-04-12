using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class ActivateDialog : MonoBehaviour {
	public void Activate() {
		//print (GlobalVariables.dialog);
		int currPrize = Int32.Parse (gameObject.name) - 1;
		//Debug.Log (Int32.Parse (GlobalVariables.Costs [currPrize]) < GlobalScore.score/100);
		//print(GlobalVariables.dialog);
		if (GlobalCredits.credits >= (Int32.Parse (GlobalVariables.Costs [currPrize]))) {
			GlobalVariables.dialog = currPrize + 1;
		}
	}
}
