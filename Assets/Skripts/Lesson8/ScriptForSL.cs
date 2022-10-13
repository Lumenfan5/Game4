using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptForSL : MonoBehaviour
{    
    public void LoadData(Save.SaveData save)
    {
        transform.position = new Vector3(save.Position.x, save.Position.y, save.Position.z);
    }
}
