using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectScoring : MonoBehaviour {

    public int scorePerHit = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        ScoreKeeper scorekeep = FindObjectOfType<ScoreKeeper>();
        scorekeep.IncrementScore(scorePerHit);
    }
}

