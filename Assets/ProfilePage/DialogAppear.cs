using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;
using UnityEditor;

public class DialogAppear : MonoBehaviour {

	// Use this for initialization
	public void Start () {
		//GlobalVariables.dialog = 0;
		GameObject.Find ("Dialog Box").transform.localScale = new Vector3(0, 0, 0);
	}

	void Update () {
		if (GlobalVariables.dialog > 0) {
			GameObject.Find ("Dialog Box").transform.localScale = new Vector3(1, 1, 1);
		}

		//Text  text = GetComponentInChildren<Text>();
		//Debug.Log (gameObject.name);
		//Text[] textarray = gameObject.GetComponentsInChildren<Text>();
//		int currPrize = Int32.Parse (gameObject.name) - 1;
//		//Debug.Log (text.text);
//		if (GlobalScore.score >= Int32.Parse (GlobalVariables.Costs [currPrize])) {
//			Debug.Log ("hi");
//			gameObject.SetActive (AssetDatabase.LoadAssetAtPath("Assets/ProfilePage/DialogBox.prefab",typeof(GameObject)));
//			GlobalScore.score -= Int32.Parse (GlobalVariables.Costs [currPrize]);
//		}
	}

}
