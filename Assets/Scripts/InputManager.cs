using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour {

	public GameObject pauseMenu;
	public GameObject responseMenu;
	public Button[] pauseButtons;
	public Button[] dialogueButtons;

	private Vector3 openUI = new Vector3(1,1,1);
	private Vector3 closeUI = new Vector3(0,0,0);

	void Start(){
		if (!pauseMenu) 
			Debug.Log ("No pause menu attached to inputManager");
		if (!responseMenu)
			Debug.Log ("No response menu attached to inputManager");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Pause")) {
			if (pauseMenu.transform.localScale == openUI) {
				Time.timeScale = 1;
				CloseUI (pauseMenu);
			} else {
				Time.timeScale = 0;
				OpenUI (pauseMenu);
			}
		}
	}

	void OpenUI(GameObject gameObject){
		gameObject.transform.localScale = openUI;
		//Selects a button if a button exist
		if(gameObject.GetComponentInChildren<Button> ())
			gameObject.GetComponentInChildren<Button> ().Select ();
	}

	void CloseUI(GameObject gameObject){
		gameObject.transform.localScale = closeUI;
	}
}
