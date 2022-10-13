using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoadMan : MonoBehaviour
{
    string filePath;
    public List<GameObject> SphereSave = new List<GameObject>();

   

    private void Start()
    {
        filePath = Application.persistentDataPath + "/MySaveData.dat";
    }
    public void SaveGame()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream fs = new FileStream(filePath, FileMode.Create);
        Save save = new Save();
        save.SaveObject(SphereSave);

        bf.Serialize(fs, save);
        fs.Close();
        Debug.Log("сохранение");
    }

    public void LoadGame()
    {
        if (!File.Exists(filePath))
            return;

        BinaryFormatter bf = new BinaryFormatter();
        FileStream fs = new FileStream(filePath, FileMode.Open);
        Save save = (Save)bf.Deserialize(fs);
        fs.Close();

        int i = 0;
        foreach(var sphere in save.SData)
        {
            SphereSave[i].GetComponent<ScriptForSL>().LoadData(sphere);
            i++;
        }
        Debug.Log("загрузка");
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.F5))
        {
            SaveGame();
        }

        if (Input.GetKey(KeyCode.F6))
        {
            LoadGame();
        }
    }

}

[System.Serializable]
public class Save
{
    [System.Serializable]
    public struct Vec3
    {
        public float x, y, z;
        public Vec3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }

    [System.Serializable]
    public struct SaveData
    {
        public Vec3 Position;
       
        public SaveData (Vec3 pos)
        {
            Position = pos;
           
        }

    }

    public List<SaveData> SData = new List<SaveData>();

    public void SaveObject(List<GameObject> SphereSave)
    {
        foreach (var go in SphereSave)
        {
            var sphere = go.GetComponent<ScriptForSL>();
            Vec3 pos = new Vec3(go.transform.position.x, go.transform.position.y, go.transform.position.z);
            
            SData.Add(new SaveData(pos));
        }

    }
}