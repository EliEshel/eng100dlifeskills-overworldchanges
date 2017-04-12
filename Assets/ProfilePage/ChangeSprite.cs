using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ChangeSprite : MonoBehaviour {

	public static int currSprite = 0;

	public void UpdateSprite () {
		if (ChangeSprite.currSprite == 0) {
			SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer> ();
			spriteRenderer.sprite = (Sprite)AssetDatabase.LoadAssetAtPath ("Assets/Art/Ninjagirl.png", typeof(Sprite));
			ChangeSprite.currSprite += 1;
			print ("hi");
		}
		else if (ChangeSprite.currSprite == 1) {
			SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer> ();
			spriteRenderer.sprite = (Sprite)AssetDatabase.LoadAssetAtPath ("Assets/Art/Ninjaboy.png", typeof(Sprite));
			ChangeSprite.currSprite = 0;
		}
//		else if (ChangeSprite.currSprite == 1) {
//			SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = (Sprite)AssetDatabase.LoadAssetAtPath ("Assets/Art/Pumpkin.png", typeof(Sprite));
//			ChangeSprite.currSprite += 1;
//		} else if (ChangeSprite.currSprite == 2) {
//			SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = (Sprite)AssetDatabase.LoadAssetAtPath ("Assets/Art/Knight.png", typeof(Sprite));
//			ChangeSprite.currSprite += 1;
//		}
//		else if (ChangeSprite.currSprite == 3) {
//			SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer> ();
//			spriteRenderer.sprite = (Sprite)AssetDatabase.LoadAssetAtPath ("Assets/Art/Ninjaboy.png", typeof(Sprite));
//			ChangeSprite.currSprite -= 3;
//		}
	}
}
