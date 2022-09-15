using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    private void Start()
    {
        transform.position = new Vector3(71f, 10f, -183f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fall"))
        {
            transform.position = new Vector3(71f, 10f, -183f);
        }
    }
}
