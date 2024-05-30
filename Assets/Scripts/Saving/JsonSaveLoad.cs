using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonSaveLoad
{
        private static string file = Application.dataPath+ "/highscores.json";
    
    public static void Save()
    {
        string json = "Hello"; //JsonUtility.ToJson();

        File.WriteAllText(file, json);
    }
}
