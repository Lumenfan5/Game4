using System.Collections;
using System.Collections.Generic;
using System;
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
        private void Update()
        {
            Camera.main.fieldOfView -= Input.GetAxis("Mouse ScrollWheel")*10f;
            transform.position = Player.transform.position + _offset;

        }
        #region отключение скрипта после победы
        void DisableScript()
        {

            GetComponent<CameraController>().enabled = false;
        }

        private void OnEnable()
        {
            FinishWall.Winned += DisableScript;
        }

        private void OnDisable()
        {
            FinishWall.Winned -= DisableScript;
        }
        #endregion

    }
}

