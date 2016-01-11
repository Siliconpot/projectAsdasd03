using UnityEngine;
using System.Collections;

public class PlaceMonster : MonoBehaviour {

	public GameObject monsterPrefab;
	private GameObject monster;

	private bool canPlaceMonster() {
		return monster == null;
	}

	//Unity kutsuu OnMouseUp kun klikataan objektia
	void OnMouseUp () {
		//Kutsuttuna lisätään nomsteri, jos canPlaceMonster = true
		if (canPlaceMonster ()) {
			//kopioidaan monsterPrefab ja lisätään se kyseisen GameObjektin sijaintiin
			monster = (GameObject) 
				Instantiate(monsterPrefab, transform.position, Quaternion.identity);
			//4
			AudioSource audioSource = gameObject.GetComponent<AudioSource>();
			audioSource.PlayOneShot(audioSource.clip);

			// TODO: Deduct gold
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
