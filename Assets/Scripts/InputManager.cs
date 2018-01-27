using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour {

	public GameObject pauseMenu;

	void Start(){
		if (!pauseMenu) 
			Debug.Log ("No pause menu attached");


	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("Cancel")) {

		}
	}
}
