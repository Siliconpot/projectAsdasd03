﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class MonsterLevel {
	public int cost;
	public GameObject visualization;
}

public class MonsterData : MonoBehaviour {

	public List<MonsterLevel> levels;
	private MonsterLevel currentLevel;

	public MonsterLevel CurrentLevel {
		get {
			return currentLevel;
		}
		set {
			currentLevel = value;
			int currentLevelIndex = levels.IndexOf (currentLevel);

			GameObject levelVisualization = levels [currentLevelIndex].visualization;
			for (int i = 0; i < levels.Count; i++) {
				if (levelVisualization != null) {
					if (i == currentLevelIndex) {
						levels [i].visualization.SetActive (true);
					} else {
						levels [i].visualization.SetActive (false);
					}
				}
			}
		}
	}

	void OnEnable() {
		CurrentLevel = levels[0];
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

