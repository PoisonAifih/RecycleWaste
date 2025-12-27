using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class DataPersistenceManager : MonoBehaviour
{
    [Header("File Storage Config")]
    [SerializeField] public string fileName;


    private GameData gameData;

    private List<IdataPersistence> dataPersObjs;

    private FileDataHandler dataHandler;

    private Scene sceneName;
   public static DataPersistenceManager Instance { get; private set; }

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this.gameObject);

        
    }

    private void Start()
    {
        sceneName = SceneManager.GetActiveScene();
        if (sceneName.name == "mainMenu")
        {
            this.dataHandler = new FileDataHandler(Application.persistentDataPath, fileName);
            this.dataPersObjs = FindAllDataPersObj();
            LoadGame();

            /*
            mainm.Instance.dur_leaf = gameData.dur_leaf;
            mainm.Instance.dur_paper = gameData.dur_paper;
           mainm.Instance.dur_plas = gameData.dur_plas;

           mainm.Instance.hrgup_leaf = gameData.hrgup_leaf;
           mainm.Instance.hrgup_plas = gameData.hrgup_plas;
           mainm.Instance.hrgup_paper = gameData.hrgup_paper;

           mainm.Instance.up_leaf = gameData.up_leaf;
           mainm.Instance.up_paper = gameData.up_paper;
           mainm.Instance.up_plas = gameData.up_plas;

           mainm.Instance.trash_paper = gameData.trash_paper;
           mainm.Instance.trash_leaf = gameData.trash_leaf;
           mainm.Instance.trash_plastic = gameData.trash_plastic;

           mainm.Instance.papernew = gameData.papernew;
           mainm.Instance.bucket = gameData.bucket;
           mainm.Instance.fertiz = gameData.fertiz;

           mainm.Instance.paper_infactory = gameData.paper_infactory;
           mainm.Instance.leaf_infactory = gameData.leaf_infactory;
           mainm.Instance.plastic_infactory = gameData.plastic_infactory;

           mainm.Instance.kertas_infactory = gameData.kertas_infactory;
           mainm.Instance.pupuk_infactory = gameData.pupuk_infactory;
           mainm.Instance.ember_infactory = gameData.ember_infactory;

           mainm.Instance.duit = gameData.duit;

           mainm.Instance.sleep_paper = gameData.sleep_paper;
           mainm.Instance.sleep_leaf = gameData.sleep_leaf;
           mainm.Instance.sleep_plas = gameData.sleep_plas;

           mainm.Instance.day = gameData.day;*/
        }
        else;
    }

    /*
    public void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.sceneUnloaded += OnSceneUnloaded;
    }

    public void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
        SceneManager.sceneUnloaded -= OnSceneUnloaded;
    }
    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("On Scene Loaded");
        
        LoadGame();
    }

    public void OnSceneUnloaded(Scene scene)
    {
        Debug.Log("On Scene UnLoaded saved");
        SaveGame();
    }
*/
    public void NewGame()
    {
        this.gameData = new GameData();
    }

    public void LoadGame()
    {
        this.gameData = dataHandler.Load();

        if(this.gameData == null)
        {
            Debug.Log("no data");
            NewGame();
        }

        foreach(IdataPersistence dataPersObj in dataPersObjs)
        {
            dataPersObj.LoadData(gameData);
            Debug.Log("loadData()" + gameData.day);
        }

        Debug.Log("loaded data " + gameData.day);
    }

    public void SaveGame()
    {
        foreach (IdataPersistence dataPersObj in dataPersObjs)
        {
            dataPersObj.SaveData(ref gameData);
        }

        Debug.Log("saved data " + gameData.day);

        dataHandler.Save(gameData);
    }

    private void OnApplicationQuit()
    {
        SaveGame();
    }

    private List<IdataPersistence> FindAllDataPersObj()
    {
        IEnumerable<IdataPersistence> dataPersObjs = FindObjectsOfType<MonoBehaviour>().OfType<IdataPersistence>();

        return new List<IdataPersistence>(dataPersObjs);
    }
}
