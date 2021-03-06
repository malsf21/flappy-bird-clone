﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackgroundController : MonoBehaviour {
	private BoxCollider2D groundCollider;
	private float groundLength;
	// Use this for initialization
	void Start () {
		groundCollider = GetComponent<BoxCollider2D>();
		groundLength = groundCollider.size.x;
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x < -groundLength){
			RepositionBackground();
		}
	}
	private void RepositionBackground(){
		Vector2 offset = new Vector2(groundLength * 2f, 0);
		transform.position = (Vector2) transform.position + offset;
	}
}
