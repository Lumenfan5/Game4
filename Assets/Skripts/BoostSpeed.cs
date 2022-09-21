using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public class BoostSpeed : MonoBehaviour
    {

        [SerializeField] private PlayerController moveScript;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                BoostingSpeed();
                other.transform.gameObject.tag = "God";
            }
        }

        void BoostingSpeed()
        {
            Destroy(gameObject);
            float new_speed = 30f;
            float new_run_speed = 50f;
            moveScript.InStallSpeed(new_speed, new_run_speed);
        }
    }
}