using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOfBound : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(collision.gameObject);
        }
    }
}
