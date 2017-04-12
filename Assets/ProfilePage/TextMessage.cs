using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Linq;
using System;

public class TextMessage : MonoBehaviour {


	public void UpdateText() {
//		GameObject g = GameObject.Find(this.name);
//		Button b = g.GetComponent<Button> ();
//		string txt = b.GetComponentInChildren<Text> ().text;
//		Debug.Log (txt);
		Text text = GetComponentInChildren<Text>();
//		Debug.Log (gameObject.transform.parent.name);
		int currPrize = Int32.Parse (gameObject.transform.parent.name) - 1;
		if (GlobalCredits.credits < Int32.Parse (GlobalVariables.Costs [currPrize])) { //(int)GlobalVariables.Costs[0]) {
			text.text = "Not enough points";
		}
	}


}