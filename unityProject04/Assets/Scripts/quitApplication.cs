using UnityEngine;
using System.Collections;

public class quitApplication : MonoBehaviour {

	// Use this for initialization
	void OnMouseOver () {

		if (Input.GetMouseButton (0))
			Application.Quit();

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.Escape))
			Application.Quit();
	
	}
}
