using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CharacterOnStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer> ();
		//spriteRenderer.sprite = Resources.Load<Sprite>("HarryPotterS4S");
		spriteRenderer.sprite = (Sprite)AssetDatabase.LoadAssetAtPath ("Assets/Art/Ninjaboy.png", typeof(Sprite));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
