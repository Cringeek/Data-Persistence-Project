using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataSave : MonoBehaviour
{
    public static DataSave instanse;
    public static string playerName;
    public static int score = 0;    


    // Start is called before the first frame update
    void Awake()
    {
        if (instanse != null)
        {
            Destroy(gameObject);
            return;            
        }

        instanse = this;
        DontDestroyOnLoad(gameObject);      

    }


    [Serializable] class SaveData
    {
        public string playerName;
        public int score;
    }

    public static void SaveHighScore()
    {
        SaveData data = new SaveData();

        data.playerName = MenuUI.currentPlayerName;
        data.score = score;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    } 
    
    public static void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);

            SaveData data = JsonUtility.FromJson<SaveData>(json);

            playerName = data.playerName;
            score = data.score;
        }
    }

  




}
