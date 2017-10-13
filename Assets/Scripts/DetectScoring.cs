using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectScoring : MonoBehaviour {

    public int scorePerHit = 1;

    void OnCollisionEnter(Collision collision)
    {
        ScoreKeeper scorekeep = FindObjectOfType<ScoreKeeper>();
        scorekeep.IncrementScore(scorePerHit);
    }
}

