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
        //Cargamos los datos guardados al apretar L
        if(Input.GetKeyDown(KeyCode.L)){
            LoadData();
        }
        //Buscamos el "Pass Level" del nivel y nos asgeuramos de que el bool isVR sea igual al del "Controller" para que al ganar el nivel, nos lleve al menú correcto
        pl = GameObject.FindGameObjectWithTag("Pass Level").GetComponent<PassLevel>();
        pl.isVR = isVR;
    }

    private void LoadData(){
        //Cargar los datos
        if(File.Exists(saveFile)){
            string content = File.ReadAllText(saveFile);
            gameData = JsonUtility.FromJson<GameDataScript>(content);

            levels = gameData.levelsData;
        }else{
            Debug.Log("File doesn´t exist");
        }
    }

    private void SaveData(){
        //Guardar los datos
        GameDataScript newData = new GameDataScript()
        {
            levelsData = levels
        };

        string JSONChain = JsonUtility.ToJson(newData);

        Debug.Log(JSONChain);

        File.WriteAllText(saveFile, JSONChain);
    }

    public void UnlockLevel(int level){
        //Desbloquear nivel y guardar la partida
        levels[level] = true;
        SaveData();
    }
}