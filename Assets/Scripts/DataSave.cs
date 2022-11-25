using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSave : MonoBehaviour
{
    public static DataSave instanse;
    public static string playerName;
    public int score;


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

  




}
