using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public class PenaltySpeed : MonoBehaviour
    {
        [SerializeField] private PlayerController moveScript;
        
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
