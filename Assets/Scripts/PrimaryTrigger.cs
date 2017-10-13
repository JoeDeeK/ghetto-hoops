using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimaryTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        SecondaryTrigger trigger = GetComponentInChildren<SecondaryTrigger>();
        trigger.ExpectedCollider(collider);
    }
}
