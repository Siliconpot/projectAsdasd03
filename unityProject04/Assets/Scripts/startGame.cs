using UnityEngine;
using System.Collections;

public class startGame : MonoBehaviour {

	void OnMouseOver () {

		if (Input.GetMouseButton (0))
			Application.LoadLevel("GameScene");

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
