using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{

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

    public int up_paper;
    public int up_leaf;
    public int up_plas;

    public int hrgup_paper;
    public int hrgup_leaf;
    public int hrgup_plas;

    public int hrgjual_paper;
    public int hrgjual_leaf;
    public int hrgjual_plas;

    public bool sleep_paper;
    public bool sleep_leaf;
    public bool sleep_plas;

    public int day;

    public bool opdone;

    public GameData()
    {
        this.day = 1;

        this.up_paper = 1;
        this.up_leaf = 1;
        this.up_plas = 1;

        this.hrgup_paper = 100;
        this.hrgup_leaf = 150;
        this.hrgup_plas = 200;

        this.hrgjual_paper = 5;
        this.hrgjual_leaf = 10;
        this.hrgjual_plas = 15;

        this.opdone = false;

        this.sleep_leaf = false;
        this.sleep_paper = false;
        this.sleep_plas = false;
    }
}

    

