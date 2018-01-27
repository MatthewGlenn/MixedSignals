using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {

	public Button[] buttons;
	public bool enabledInput = true;
	public bool player1Control = true;
	public bool player2Control = false;
	private int currentSelection = 0;

	// Use this for initialization
	void Start () {
		buttons = new Button[transform.childCount];
		for (int i = 0; i < transform.childCount; i++)
		{
			buttons[i] = transform.GetChild(i).gameObject.GetComponent<Button>();
		}

		buttons [currentSelection].Select ();
	}

	void Update(){
		if (enabledInput) {
			inputManagement ();
		}
	}

	void inputManagement(){
		if (player1Control) {
			if (Input.GetButtonDown ("Player1Up")) {
				CurrentSelectionUpdate (1);
				buttons [currentSelection].Select ();
			}
			if (Input.GetButtonDown ("Player1Down")) {
				CurrentSelectionUpdate (-1);
				buttons [currentSelection].Select ();
			}
			if(Input.GetButtonDown("Player1Select")){
				buttons [currentSelection].onClick.Invoke ();
			}
		} else if (player2Control) {
			if (Input.GetButtonDown ("Player2Up")) {
				CurrentSelectionUpdate (1);
				buttons [currentSelection].Select ();
			}
			if (Input.GetButtonDown ("Player2Down")) {
				CurrentSelectionUpdate (-1);
				buttons [currentSelection].Select ();
			}
			if(Input.GetButtonDown("Player2Select")){
				buttons [currentSelection].onClick.Invoke ();
			}
		}
	}
	void CurrentSelectionUpdate(int update){
		if (update == 1) {
			if (currentSelection == buttons.Length - 1) {
				currentSelection = 0;
			} else {
				currentSelection += update;
			}
		}else if(update == -1){
			if (currentSelection == 0) {
				currentSelection = buttons.Length - 1;
			} else {
				currentSelection += update;
			}
	}
}
}