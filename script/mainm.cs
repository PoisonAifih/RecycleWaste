using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainm : MonoBehaviour, IdataPersistence
{
    public static mainm Instance { get; private set; }
    private FileDataHandler dataHandler;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        this.dataHandler = new FileDataHandler(Application.persistentDataPath, DataPersistenceManager.Instance.fileName);
    }


    public bool tipshow;
    public int tiprand;

    public int up_paper;
    public int up_leaf;
    public int up_plas;

    public int hrgup_paper;
    public int hrgup_leaf;
    public int hrgup_plas;

    public int hrgjual_paper;
    public int hrgjual_leaf;
    public int hrgjual_plas;

    public int trash_paper;
    public int trash_leaf;
    public int trash_plastic;

    public int papernew;
    public int bucket;
    public int fertiz;

    public int paper_infactory;
    public int leaf_infactory;
    public int plastic_infactory;

    public int kertas_infactory;
    public int pupuk_infactory;
    public int ember_infactory;

    public int duit;

    public bool sleep_paper;
    public bool sleep_leaf;
    public bool sleep_plas;

    public int day;

    public bool opdone;

    public void SaveData(ref GameData data)
    {
        data.hrgjual_leaf = this.hrgjual_leaf;
        data.hrgjual_paper = this.hrgjual_paper;
        data.hrgjual_plas = this.hrgjual_plas;

        data.hrgup_leaf = this.hrgup_leaf;
        data.hrgup_plas = this.hrgup_plas;
        data.hrgup_paper = this.hrgup_paper;

        data.up_leaf = this.up_leaf;
        data.up_paper = this.up_paper;
        data.up_plas = this.up_plas;

        data.trash_paper = this.trash_paper;
        data.trash_leaf = this.trash_leaf;
        data.trash_plastic = this.trash_plastic;

        data.papernew = this.papernew;
        data.bucket = this.bucket;
        data.fertiz = this.fertiz;

        data.paper_infactory = this.paper_infactory;
        data.leaf_infactory = this.leaf_infactory;
        data.plastic_infactory = this.plastic_infactory;

        data.kertas_infactory = this.kertas_infactory;
        data.pupuk_infactory = this.pupuk_infactory;
        data.ember_infactory = this.ember_infactory;

        data.duit = this.duit;

        data.sleep_paper = this.sleep_paper;
        data.sleep_leaf = this.sleep_leaf;
        data.sleep_plas = this.sleep_plas;

        data.day = this.day;
        Debug.Log("save mainm day: " + data.day);

        //dataHandler.Save(data);
    }
    public void LoadData(GameData data)
    {
        Debug.Log("mainm day: " + this.day);

        this.hrgjual_leaf = data.hrgjual_leaf;
        this.hrgjual_paper = data.hrgjual_paper;
        this.hrgjual_plas = data.hrgjual_plas;

        this.hrgup_leaf = data.hrgup_leaf;
        this.hrgup_plas = data.hrgup_plas;
        this.hrgup_paper = data.hrgup_paper;

        this.up_leaf = data.up_leaf;
        this.up_paper = data.up_paper;
        this.up_plas = data.up_plas;

        this.trash_paper = data.trash_paper;
        this.trash_leaf = data.trash_leaf;
        this.trash_plastic = data.trash_plastic;

        this.papernew = data.papernew;
        this.bucket = data.bucket;
        this.fertiz = data.fertiz;

        this.paper_infactory = data.paper_infactory;
        this.leaf_infactory = data.leaf_infactory;
        this.plastic_infactory = data.plastic_infactory;

        this.kertas_infactory = data.kertas_infactory;
        this.pupuk_infactory = data.pupuk_infactory;
        this.ember_infactory = data.ember_infactory;

        this.duit = data.duit;

        this.sleep_paper = data.sleep_paper;
        this.sleep_leaf = data.sleep_leaf;
        this.sleep_plas = data.sleep_plas;

        this.day = data.day;

    }

}
