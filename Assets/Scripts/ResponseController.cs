using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResponseController : MonoBehaviour {

	public GameObject option1;
	public GameObject option2;
	public GameObject option3;

	private Button option1Button;
	private Button option2Button;
	private Button option3Button;

	// Use this for initialization
	void Start () {
		FindButtons ();
		option2Button.Select ();
	}

	void FindButtons(){
		option1Button = option1.GetComponent<Button> ();
		option2Button = option2.GetComponent<Button> ();
		option3Button = option3.GetComponent<Button> ();

		if (!option1Button)
			Debug.LogError ("Option1 Button not assigned to Response Controller");
		if (!option2Button)
			Debug.LogError ("Option2 Button not assigned to Response Controller");
		if (!option3Button)
			Debug.LogError ("Option3 Button not assigned to Response Controller");
	}
}