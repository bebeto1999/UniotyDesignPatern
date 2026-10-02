using UnityEngine;
using System.IO;
using UnityEditor;

public class SaveSystem : MonoBehaviour
{
    public int GetWave()
    {

        if (File.Exists(Application.persistentDataPath + "Save.txt"))
            return int.Parse(File.ReadAllText(Application.persistentDataPath + "Save.txt"));

        else 
            return 1;
    }

    public void SaveCurrentWave(float currentWave)
    {
        File.WriteAllText(Application.persistentDataPath + "Save.txt", currentWave.ToString());
    }
    
}
