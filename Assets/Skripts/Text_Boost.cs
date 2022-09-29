using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace Geekbrains
{
    public class Text_Boost : MonoBehaviour
    {
        public void Start()
        {
            Norm();
        }


        public void BonusSpeed()
        {
            GetComponent<Canvas>().enabled = true;
            Invoke(nameof(Norm), 2.2f);

        }

        void Norm()
        {
            GetComponent<Canvas>().enabled = false;
        }


    }

}


