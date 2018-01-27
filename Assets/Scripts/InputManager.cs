using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour {

	public GameObject pauseMenu;
	public DialogueController dialogueController;

	private Vector3 openUI = new Vector3(1,1,1);
	private Vector3 closeUI = new Vector3(0,0,0);

	void Start(){
		if (!pauseMenu) 
			Debug.Log ("No pause menu attached to inputManager");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Pause")) {
			if (pauseMenu.transform.localScale == openUI) {
				Time.timeScale = 1;
				CloseUI (pauseMenu);
			} else {
				Time.timeScale = 0;
				OpenUI (pauseMenu, true, true);
			}
		}
	}

	public void OpenUI(GameObject gameObject, bool player1Control, bool player2Control){
		gameObject.transform.localScale = openUI;

		//Selects a button if a button exist
		if(gameObject.GetComponentInChildren<Button> ())
			gameObject.GetComponentInChildren<Button> ().Select ();

		//Goes into ButtonController and enables input and player controls
		gameObject.GetComponent<ButtonController> ().enabledInput = true; //Enables interaction with UI
		gameObject.GetComponent<ButtonController> ().player1Control = player1Control; //Sets player 1 control
		gameObject.GetComponent<ButtonController> ().player2Control = player2Control; //Sets player 2 control

	}

	public void CloseUI(GameObject gameObject){
		gameObject.transform.localScale = closeUI;
		if(gameObject.GetComponent<ButtonController> ()){
			gameObject.GetComponent<ButtonController> ().enabledInput = false; //disables interaction with UI
		}
	}
}
