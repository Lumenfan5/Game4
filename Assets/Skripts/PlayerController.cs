using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public class PlayerController : MonoBehaviour
    {
        private float timeLeft = 5.0f;
        [SerializeField] private float speed;
        [SerializeField] private float run_speed;
        private Rigidbody rb;

        void Start() 
        {
            rb = GetComponent<Rigidbody>();
            speed = 20f;
            run_speed = 40f;

         }

        void FixedUpdate()
        {
            Move();
            NormalSpeed();
            NormalTag();
        }

        void NormalSpeed()
        {
            if(speed != 20f && run_speed !=40f)
            {
                timeLeft -= Time.deltaTime;
                if (timeLeft < 0)
                {
                    speed = 20f;
                    run_speed = 40f;
                    timeLeft = 5.0f;
                }
                
            }
            
        }

        void NormalTag()
        {
            if(!gameObject.CompareTag("Player"))
            {
                timeLeft -= Time.deltaTime;
                if (timeLeft < 0)
                {
                    transform.gameObject.tag = "Player";
                    timeLeft = 5.0f;
                }
            }
            
        }

        public void InStallSpeed(float new_speed, float new_run_speed)
        {
            speed = new_speed;
            run_speed = new_run_speed;
                        
        }

        public void Move()
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
        public void Boost()
        {
            speed = 30f;
            run_speed = 50f;
            transform.gameObject.tag = "God";
        }
    }
}