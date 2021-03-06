﻿using UnityEngine;
using System.Collections;

public class player_movement : MonoBehaviour {

	Animator anim;
	public float speed = 1f;
	public string playerFacing = "right";
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			if (playerFacing == "right")
			{
				playerFacing = "left";
			    Vector2 theScale = transform.localScale;
			    theScale.x *= -1;
			    transform.localScale = theScale;
			}
			transform.Translate(Vector2.left * speed * Time.deltaTime);
			anim.SetBool("walking", true);
		}
		else if (Input.GetKey (KeyCode.D)) {
			if (playerFacing == "left")
			{
				playerFacing = "right";
				Vector2 theScale = transform.localScale;
				theScale.x *= -1;
				transform.localScale = theScale;
			}
			transform.Translate(Vector2.right * speed * Time.deltaTime);
			anim.SetBool("walking", true);
		}

		if(Input.anyKey == false)
		{
			anim.SetBool("walking", false);
		}
	}

}
