﻿using UnityEngine;
using System.Collections;

public class throwhook : MonoBehaviour {

	public GameObject birdHook;
	public GameObject hook;

	GameObject curHook;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update() {


		/*if (Input.GetMouseButtonDown(0)) {


			Vector2 destiny = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Debug.Log(destiny);
			curHook = (GameObject)Instantiate(hook, transform.position, Quaternion.identity);

			curHook.GetComponent<RopeScript>().destiny = destiny;


		}*/
		/*else if (Input.GetKeyDown("e"))
		{ 
			Debug.Log("e"+(Vector2)transform.position);
			birdHook.GetComponent<RopeScript>().destiny = (Vector2)transform.position;

		}*/
		

	}
}
