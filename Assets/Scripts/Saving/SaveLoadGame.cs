using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadGame : MonoBehaviour
{
    public void SaveGame()
    {
        JsonSaveLoad.Save();
    }

    public void LoadGame()
    {
        
    }
}
