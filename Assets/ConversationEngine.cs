using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationEngine : MonoBehaviour {

	public InputManager inputManager;
	public GameObject dialogueController;
	public GameObject buttonController;

	private DateResponse dateResponse;
	private ConversationOpener conversationOpener;
	private PlayerResponse playerResponse;
	private Exchange exchange;
	private Emotion emotion;

	private int guyMood = 50;
	private int girlMood = 50;

	private int guyReaction;
	private int girlReaction;

	private bool player1Control = true;
	private bool player2Control = true;

	private string guyText = "hey";
	private string girlText = "sup";

	private string[] choices = new string[3];
	// Use this for initialization
	void Start () {
		choices [0] = "choice 0";
		choices [1] = "choice 1";
		choices [2] = "choice 2";
		UpdateDialogue ("hey", "sup");
		Invoke ("UpdateChoices", 15f);
		Invoke ("UpdateChoices", 15f);
	}

	void UpdateDialogue(string guyText, string girlText){
		dialogueController.GetComponent<DialogueController>().updateDialogue (guyText, girlText);
		inputManager.OpenUI(dialogueController, player1Control, player2Control);
	}

	void UpdateChoices(){
		inputManager.OpenUI (buttonController, player1Control, player2Control);
	}

	void InstantiateClasses(){
//		dateResponse = new DateResponse ();
//		conversationOpener = new ConversationOpener ();
//		playerResponse = new PlayerResponse ();
//		exchange = new Exchange ();
//		emotion = new Emotion ();
	}

	public void ConversationChoice(int choice){
		
	}
}
