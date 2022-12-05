using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public GameObject player;

    private void OnCollisionEnter (Collision collision)
    {
        Destroy(gameObject);
    }
}
