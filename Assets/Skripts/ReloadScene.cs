using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ReloadScene : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            ReloadScene1();
        }

    }


    public void ReloadScene1()
    {        
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);         
    }

    
}
