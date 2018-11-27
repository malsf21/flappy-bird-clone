﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingController : MonoBehaviour {
	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2(GameController.instance.scrollSpeed, 0);
	}

	// Update is called once per frame
	void Update () {
		if(GameController.instance.gameOver){
			rb.velocity = Vector2.zero;
		}
	}
}
