using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class GlobalVariables : MonoBehaviour {
    public static int hearts = 3;
    public static int score = 0;
    public static int level = 0;
	public static int dialog = 0;
    public static float speedScale = 1;
    public static float timerTime = 10f;
	public static string[] Prizes = { "Glow Stick", "Stuffed Elephant", "Slinky", "Headphones", "Miniature Fan", "Toy Car" };
	public static string[] Costs = { "10", "2000", "1500", "3000", "2000", "2000" };
	// Use this for initialization
	void Start () {
        
    }

	// Update is called once per frame
	void Update () {
	
	}
}
