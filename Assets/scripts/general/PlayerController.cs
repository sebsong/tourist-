﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	private HashSet<Item> inventory;

	private bool interacting;
	private Animator anim;

	// Use this for initialization
	void Start () {
		inventory = new HashSet<Item> ();
		interacting = false;
		anim = GetComponent<Animator> ();
		anim.SetFloat ("speed", speed);
	}
	
	// Update is called once per frame
	void Update () {
		if (!interacting) {
			Move ();
		}

		//DEBUG Inventory
		if (Input.GetKeyDown (KeyCode.I)) {
			foreach (Item item in inventory) {
				print (item.GetItemName ());
			}
		}
	}

	// Handle player movement
	void Move() {
		Vector3 dir;

		float horizontal = Input.GetAxisRaw ("Horizontal");
		float vertical = Input.GetAxisRaw ("Vertical");

		if (horizontal != 0) {
			vertical = 0f;
		} else if (vertical != 0) {
			horizontal = 0f;
		} else {
			anim.SetBool ("isMoving", false);
			return;
		}

		dir = new Vector2 (horizontal, vertical);

		anim.SetFloat ("xDir", horizontal);
		anim.SetFloat ("yDir", vertical);
		anim.SetBool ("isMoving", true);

		transform.position += dir * speed * Time.deltaTime;
	}

	public void Interact() {
		interacting = true;
	}

	public void InteractEnd() {
		interacting = false;
	}

	public void InventoryAdd (Item item) {
		inventory.Add (item);
	}

	public bool InventoryContains (Item item) {
		return inventory.Contains (item);
	}

}
