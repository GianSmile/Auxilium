using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameDataController : MonoBehaviour
{
    public string saveFile;
    public GameDataScript gameData = new GameDataScript();
    public bool[] levels;
    public bool isVR;
    private PassLevel pl;

    private void Awake() {
        levels = new bool[] { true, false, false, false, false, false };
        GameObject clon = GameObject.FindGameObjectWithTag("Controller");
        if(clon != null)Destroy(gameObject);
        gameObject.tag = "Controller";
        DontDestroyOnLoad(gameObject);
        saveFile = Application.dataPath + "/save.json";
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.L)){
            LoadData();
        }
        pl = GameObject.FindGameObjectWithTag("Pass Level").GetComponent<PassLevel>();
        pl.isVR = isVR;
    }

    private void LoadData(){
        if(File.Exists(saveFile)){
            string content = File.ReadAllText(saveFile);
            gameData = JsonUtility.FromJson<GameDataScript>(content);

            levels = gameData.levelsData;
        }else{
            Debug.Log("File doesn´t exist");
        }
    }

    private void SaveData(){
        GameDataScript newData = new GameDataScript()
        {
            levelsData = levels
        };

        string JSONChain = JsonUtility.ToJson(newData);

        Debug.Log(JSONChain);

        File.WriteAllText(saveFile, JSONChain);
    }

    public void PassLevel(int level){
        levels[level] = true;
        SaveData();
    }
}