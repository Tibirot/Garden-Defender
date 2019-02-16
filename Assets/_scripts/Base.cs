using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D otherCollider)
    {   
        GameObject otherObject = otherCollider.gameObject;

        if (otherObject.GetComponent<Attacker>())
        {
            FindObjectOfType<BaseHealth>().BaseHit();
            Destroy(otherCollider.gameObject);
        }
    }
}
