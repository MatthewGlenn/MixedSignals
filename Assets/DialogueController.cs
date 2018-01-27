using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour {
	
	public Text guyText;
	public Text girlText;

	public void updateDialogue(string guyDialogue, string girlDialogue){
		guyText.text = guyDialogue;
		girlText.text = girlDialogue;
	}
}
