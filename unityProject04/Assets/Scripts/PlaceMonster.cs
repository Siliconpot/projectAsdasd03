﻿using UnityEngine;
using System.Collections;

public class PlaceMonster : MonoBehaviour {

	public GameObject monsterPrefab;
	private GameObject monster;

	private bool canPlaceMonster() {
		int cost = monsterPrefab.GetComponent<MonsterData> ().levels[0].cost;
		return monster == null && gameManager.Gold >= cost;
	}

	private bool canUpgradeMonster() {
		if (monster != null) {
			MonsterData monsterData = monster.GetComponent<MonsterData> ();
			MonsterLevel nextLevel = monsterData.getNextLevel();
			if (nextLevel != null) {
				return gameManager.Gold >= nextLevel.cost;
			}
		}
		return false;
	}

	private GameManagerBehavior gameManager;

	//Unity kutsuu OnMouseUp kun klikataan objektia
	void OnMouseUp () {
		//Kutsuttuna lisätään nomsteri, jos canPlaceMonster = true
		if (canPlaceMonster ()) {
			//kopioidaan monsterPrefab ja lisätään se kyseisen GameObjektin sijaintiin
			monster = (GameObject) 
				Instantiate(monsterPrefab, transform.position, Quaternion.identity);
			AudioSource audioSource = gameObject.GetComponent<AudioSource>();
			audioSource.PlayOneShot(audioSource.clip);

			gameManager.Gold -= monster.GetComponent<MonsterData>().CurrentLevel.cost;
		} else if (canUpgradeMonster()) {
			monster.GetComponent<MonsterData>().increaseLevel();
			AudioSource audioSource = gameObject.GetComponent<AudioSource>();
			audioSource.PlayOneShot(audioSource.clip);
			gameManager.Gold -= monster.GetComponent<MonsterData>().CurrentLevel.cost;
		}
	}

	// Use this for initialization
	void Start () {

		gameManager =
			GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
