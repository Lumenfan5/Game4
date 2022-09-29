using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace Geekbrains
{
    public class ScreenWin : FinishWall
    {
        private void Start()
        {
            Norm();
        }       

        void Norm()
        {
            GetComponent<Canvas>().enabled = false;
        }

        private void SWin()
        {
            GetComponent<Canvas>().enabled = true;
        }

        private void OnEnable()
        {
            FinishWall.Winned += SWin;
        }

        private void OnDisable()
        {
            FinishWall.Winned -= SWin;
        }
    }
    
}