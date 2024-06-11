using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using system.IO;

public class GameDataController : MonoBehaviour
{
    public string saveFile;
    public GameDataScript gameData = new GameDataScript();
    public bool[] levels;

    private void Awake() {
        levels =  = {false,false,false,false,false,false};
        DontDestroyOnLoad(gameObject);
        saveFile = Application.dataPath + "/save.json";
    }

    private void LoadData(){
        if(File.Exists(saveFile)){
            string content = File.ReadAllText(saveFile);
            gameData = JsonUtility.FromJson<GameDataScript>(content);

            levels = content.levelsData;
        }else{
            Debug.Log("File doesn´t exist");
        }
    }

    private void SaveData(){
        GameDataScript newData = new GameDataScript()
        {
            levelsData = levels;
        };

        string JSONChain = JsonUtility.ToJson(newData);

        File.WriteAllText(saveFile, JSONChain);

    }

    private void PassLevel(int level){
        levels[level] = true;
        SaveData();
    }
}