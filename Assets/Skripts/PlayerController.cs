using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public class PlayerController : MonoBehaviour
    {

        [SerializeField] private float speed = 20f;
        [SerializeField] private float run_speed = 40f;
        private Rigidbody rb;

        void Start() 
        {
            rb = GetComponent<Rigidbody>();
        }

        void FixedUpdate()
        {
            Move();            
        }

        void Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.AddForce(movement * run_speed);
            }
            else
            {
                rb.AddForce(movement * speed);
            }
                        
            
            

        }
    }
}