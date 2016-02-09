using UnityEngine;
using System.Collections;

public class fastForward : MonoBehaviour {

	// Use this for initialization
	void OnMouseOver () {

		if (Input.GetMouseButton (0))
			Time.timeScale = 5f;
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButton (0) == false)
			Time.timeScale = 1f;
	
	}
}
