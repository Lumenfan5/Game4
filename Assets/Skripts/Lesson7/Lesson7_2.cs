using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;


namespace Geekbrains
{
    public static class Lesson7
    {    
             
        public static int Length (this string self)
        {            
            int n = 0;
            foreach (object element in self)
            {
                n++;                
            }
            Debug.Log(n);
            return n;
        }
    }

    public class Lesson7_2 : MonoBehaviour
    {
        string str = "в этой строке 43 символа вместе с пробелами";
        private void Start()
        {
            _ = str.Length();
        }
    }
    
}

