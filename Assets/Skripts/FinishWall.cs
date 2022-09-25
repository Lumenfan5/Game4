using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public class FinishWall : MonoBehaviour
    {                
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("God"))
            {
                GameObject[] gameObjects;
                gameObjects = GameObject.FindGameObjectsWithTag("SphereWin");

                if (gameObjects.Length == 0)
                {
                    Debug.Log("Win!!!!!");
                }

            }
        }
        

    }
}

