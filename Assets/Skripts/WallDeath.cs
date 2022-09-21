using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDeath : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.position = new Vector3(71f, 10f, -183f);
        }
    }
}
