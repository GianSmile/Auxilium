using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using system.IO;

public class GameDataController : MonoBehaviour
{
    public string saveFile;
    public GameData gameData = new GameData();
    public bool[] levels = {false,false,false,false,false,false};

    private void Awake() {
        DontDestroyOnLoad(gameObject);
        archivoDeGuardado = Application.dataPath + "save.json";
    }

    private void LoadData(){
        if(File.Exists(saveFile)){
            string content = File.ReadAllText(saveFile);
            gameData = JsonUtility.FromJson<GameData>(content);

            levels = content.levelsPassed;
        }else{
            Debug.Log("File doesn´t exist");
        }
    }

    private void SaveData(){
        GameData newData = new GameData()
        {
            levelsPassed = levels;
        };

        string JSONChain = JsonUtility.ToJson(newData);

        File.WriteAllText(saveFile, JSONChain);

    }

    private void PassLevel(int level){
        levels[level] = true;
        SaveData();
    }
}