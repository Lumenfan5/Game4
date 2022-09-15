using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public sealed class CameraController : MonoBehaviour
    {
        public Transform Player;
        private Vector3 _offset;
        private void Start()
        {
            _offset = transform.position - Player.transform.position;
        }
        private void LateUpdate()
        {
            Camera.main.fieldOfView -= Input.GetAxis("Mouse ScrollWheel")*10f;
            transform.position = Player.transform.position + _offset;           

        }
    }
}

