using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeRemainingDisplay : MonoBehaviour {
    LevelManager levelManager;
    Text text;

	// Use this for initialization
	void Start () {
        levelManager = FindObjectOfType<LevelManager>();
        text = FindObjectOfType<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "Time Remaining:   " + levelManager.timeTillNextLevel;
	}
}
