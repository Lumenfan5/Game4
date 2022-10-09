using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Lesson7_3 : MonoBehaviour
{
    
    void Start()
    {
       Ñounting();
    }
    private void Ñounting()
    {
        List<int> list = new();
        list.AddRange(new int[] { 20, 1, 4, 8, 9, 4, 4 });
        
        foreach (int val in list.Distinct())
        {
            Debug.Log(val + " - " + list.Where(x => x == val).Count() + " ðàç");
        }
    }
   
   




}
