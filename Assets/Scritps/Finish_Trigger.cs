using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish_Trigger : MonoBehaviour {
	public Text finishText;

	int counter = 0;
	
	// Update is called once per frame
	void Update () {

		if (counter > 2) {

			finishText.text = "FINISH!!!";
		}
		
	}

	void OnTriggerEnter(Collider col){

		counter++;
	}
}
