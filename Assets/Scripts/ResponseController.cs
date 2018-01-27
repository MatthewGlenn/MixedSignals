using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ResponseController : MonoBehaviour {

	public GameObject option1;
	private Button option1Button;
	public GameObject option2;
	private Button option2Button;
	public GameObject option3;
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
			Debug.LogError ("option1Button not added to ResponseController");
		if (!option2Button)
			Debug.LogError ("option2Button not added to ResponseController");
		if (!option3Button)
			Debug.LogError ("option3Button not added to ResponseController");
	}

	public void SelectButton(){
		gameObject.transform.localScale = new Vector3 (0, 0, 0);
	}

}