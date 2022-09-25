using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public class PenaltySpeed : MonoBehaviour
    {
        [SerializeField] private PlayerController moveScript;

        private void Start()
        {
            if (moveScript == null)
            {
                Debug.Log("it is required to install an object for script development");
                
                //Я понимаю принцип работы исключений, но не нашёл где их можно применить в моём случае.
                //Воспользовался советом из методички относительно работы с исключениями (проверка на null)
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                SlowSpeed();         
            }
        }

        void SlowSpeed()
        {
            Destroy(gameObject);
            float new_speed = 3f;
            float new_run_speed = 5f;
            moveScript.InStallSpeed(new_speed, new_run_speed);
        }
            

    }
}
