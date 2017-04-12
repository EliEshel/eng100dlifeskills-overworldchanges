using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;
using UnityEditor;

public class Disapear : MonoBehaviour {

	public void Disappear () {
		GameObject.Find ("Dialog Box").transform.localScale = new Vector3(0, 0, 0);
		GlobalVariables.dialog = 0;
	}
}
