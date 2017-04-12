using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextChange : MonoBehaviour {

	void Start () {
		gameObject.SetActive (false);
	}

	public void MakeAppear(string Text){
		gameObject.SetActive(true);
		gameObject.GetComponent<Renderer> ().material.color += new Color (0, 0, 0, 1f);
	}
		
	public void Update()
	{
		if (gameObject.activeInHierarchy) {
			//gameObject.GetComponent<Text> ().CrossFadeAlpha(0.0f,0.05f,false);
			//Debug.Log (gameObject.GetComponent<Renderer> ().material.color.a);
			if (gameObject.GetComponent<Renderer> ().material.color.a > 0) {
				gameObject.GetComponent<Renderer> ().material.color -= new Color (0, 0, 0, .01f);
			} else {
				gameObject.SetActive (false);
			}
			//yield Fade.use.Alpha((gameObject.GetComponent<Renderer> ().material),1.0f,0.0f,3.0f);
		}
	}


}
