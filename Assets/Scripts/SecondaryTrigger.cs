using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryTrigger : MonoBehaviour {

    Collider expectedCollider;

    public void ExpectedCollider(Collider collider)
    {
        expectedCollider = collider;
    }

    void OnTriggerEnter(Collider otherCollider)
    {
        if(otherCollider == expectedCollider)
        {
            ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
            scoreKeeper.IncrementScore(1);
        }
    }
}
