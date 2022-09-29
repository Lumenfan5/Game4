using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace Geekbrains
{
    
    public class FinishWall : MonoBehaviour
    {
        public static Action Winned;

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("God"))
            {
                Win();
            }
        } 
        
        public void Win()
        {
            GameObject[] gameObjects;
            gameObjects = GameObject.FindGameObjectsWithTag("SphereWin");

            if (gameObjects.Length == 0)
            {
                //Debug.Log("Win!!!!!");
                Winned?.Invoke();
            }
        }
            

    }


}





