using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class factorygm : MonoBehaviour
{
    public GameObject paperUI;
    public GameObject pupukUI;
    public GameObject plasUI;
    public GameObject sellUI;
    public GameObject sleepUI;
    public GameObject videoUI;

    public float taim;
    public bool vidmulai = false;

    private ui yuai;

    public Text lvl_paper;
    public Text lvl_leaf;
    public Text lvl_plas;

    public Text durasi_paper;
    public Text durasi_leaf;
    public Text durasi_plas;

    public int touch;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        videoUI.SetActive(false);
        taim = 1.8f;

        yuai = FindObjectOfType<ui>();

        if (mainm.Instance.up_leaf < 10)
        {
            lvl_leaf.text = "Sell price " + mainm.Instance.up_leaf + "Upgrade = " + mainm.Instance.hrgup_leaf + "$";
        }
        else if (mainm.Instance.up_leaf == 10)
        {
            lvl_leaf.text = "level " + mainm.Instance.up_paper;
        }
        if (mainm.Instance.up_paper < 10)
        {
            lvl_paper.text = "level " + mainm.Instance.up_paper + "Upgrade = " + mainm.Instance.hrgup_paper + "$";
        }
        else if (mainm.Instance.up_paper == 10)
        {
            lvl_paper.text = "level " + mainm.Instance.up_paper;
        }
        if (mainm.Instance.up_plas < 10)
        {
            lvl_plas.text = "level " + mainm.Instance.up_plas + "Upgrade = " + mainm.Instance.hrgup_plas + "$";
        }
        else if (mainm.Instance.up_plas == 10)
        {
            lvl_plas.text = "level " + mainm.Instance.up_plas;
        }

        durasi_leaf.text = "Sell price = " + mainm.Instance.hrgjual_leaf + " $";
        durasi_paper.text = "Sell price = " + mainm.Instance.hrgjual_paper + " $";
        durasi_plas.text = "Sell price = " + mainm.Instance.hrgjual_plas + " $";

    }

    // Update is called once per frame
    void Update()
    {

        durasi_leaf.text = "Sell price = " + mainm.Instance.hrgjual_leaf + " $";
        durasi_paper.text = "Sell price = " + mainm.Instance.hrgjual_paper + " $";
        durasi_plas.text = "Sell price = " + mainm.Instance.hrgjual_plas + " $";

        if (mainm.Instance.up_leaf < 10)
        {
            lvl_leaf.text = "level " + mainm.Instance.up_leaf + "Upgrade = " + mainm.Instance.hrgup_leaf + "$";
        }
        else if (mainm.Instance.up_leaf == 10)
        {
            lvl_leaf.text = "level " + mainm.Instance.up_paper;
        }
        if (mainm.Instance.up_paper < 10)
        {
            lvl_paper.text = "level " + mainm.Instance.up_paper + "Upgrade = " + mainm.Instance.hrgup_paper + "$";
        }
        else if (mainm.Instance.up_paper == 10)
        {
            lvl_paper.text = "level " + mainm.Instance.up_paper;
        }
        if (mainm.Instance.up_plas < 10)
        {
            lvl_plas.text = "level " + mainm.Instance.up_plas + "Upgrade = " + mainm.Instance.hrgup_plas + "$";
        }
        else if (mainm.Instance.up_plas == 10)
        {
            lvl_plas.text = "level " + mainm.Instance.up_plas;
        }

        if (Input.GetKeyDown("f"))
        {
            if(touch == 1)
            {
                mainm.Instance.paper_infactory += mainm.Instance.trash_paper;
                mainm.Instance.trash_paper = 0;
                StartCoroutine(factorybg.Instance.paper_fac());
            }
            if (touch == 2)
            {
                mainm.Instance.leaf_infactory += mainm.Instance.trash_leaf;
                mainm.Instance.trash_leaf = 0;
                StartCoroutine(factorybg.Instance.leaf_fac());
            }
            if (touch == 3)
            {
                mainm.Instance.plastic_infactory += mainm.Instance.trash_plastic;
                mainm.Instance.trash_plastic = 0;
                StartCoroutine(factorybg.Instance.plas_fac());
            }
        }

        if (Input.GetKeyDown("g"))
        {
            
            if (touch == 1)
            {
                if (mainm.Instance.kertas_infactory > 0)
                {
                    mainm.Instance.papernew += mainm.Instance.kertas_infactory;
                    mainm.Instance.kertas_infactory = 0;
                }
                    
            }
            if (touch == 2)
            {
                if (mainm.Instance.pupuk_infactory > 0)
                {
                    mainm.Instance.fertiz += mainm.Instance.pupuk_infactory;
                    mainm.Instance.pupuk_infactory = 0;
                }
                    
            }
            if (touch == 3)
            {
                if (mainm.Instance.ember_infactory > 0)
                {
                    mainm.Instance.bucket += mainm.Instance.ember_infactory;
                    mainm.Instance.ember_infactory = 0;
                }
                    
            }
        }

        if (Input.GetKeyDown("r"))
        {
            if(mainm.Instance.papernew > 0)
            {
                mainm.Instance.duit += mainm.Instance.papernew * mainm.Instance.hrgjual_paper;
                mainm.Instance.papernew = 0;
            }
            if (mainm.Instance.fertiz > 0)
            {
                mainm.Instance.duit += mainm.Instance.fertiz * mainm.Instance.hrgjual_leaf;
                mainm.Instance.fertiz = 0;
            }
            if (mainm.Instance.bucket > 0)
            {
                mainm.Instance.duit += mainm.Instance.bucket * mainm.Instance.hrgjual_plas;
                mainm.Instance.bucket = 0;
            }
            /*for (int i = 0; i < mainm.Instance.papernew && mainm.Instance.papernew > 0; i++)
            {
                mainm.Instance.papernew -= 1;
                mainm.Instance.duit += 10;
            }
            for (int i = 0; i < mainm.Instance.fertiz && mainm.Instance.fertiz > 0; i++)
            {
                mainm.Instance.fertiz -= 1;
                mainm.Instance.duit += 30;
            }
            for (int i = 0; i < mainm.Instance.bucket && mainm.Instance.bucket > 0; i++)
            {
                mainm.Instance.bucket -= 1;
                mainm.Instance.duit += 50;
            }*/
        }

        if (Input.GetKeyDown("t"))
        {

            
            if (touch == 1 && mainm.Instance.duit >= mainm.Instance.hrgup_paper && mainm.Instance.up_paper < 10)
            {
                mainm.Instance.duit -= mainm.Instance.hrgup_paper;
                mainm.Instance.hrgup_paper += 100;
                mainm.Instance.up_paper += 1;
                mainm.Instance.hrgjual_paper += 5;
            }
            if (touch == 2 && mainm.Instance.duit >= mainm.Instance.hrgup_leaf && mainm.Instance.up_leaf < 10)
            {
                mainm.Instance.duit -= mainm.Instance.hrgup_leaf;
                mainm.Instance.hrgup_leaf += 150;
                mainm.Instance.up_leaf += 1;
                mainm.Instance.hrgjual_leaf += 10;
            }
            if (touch == 3 && mainm.Instance.duit >= mainm.Instance.hrgup_plas && mainm.Instance.up_plas < 10)
            {
                mainm.Instance.duit -= mainm.Instance.hrgup_plas;
                mainm.Instance.hrgup_plas += 200;
                mainm.Instance.up_plas += 1;
                mainm.Instance.hrgjual_plas += 10;
            }
        }

        if(vidmulai == true)
        {
            Time.timeScale = 1f;
            startvideo();
            taim -= Time.deltaTime;
            if(taim <= 0)
        {
            vidmulai = false;
            stopvideo();
        }
        }
        
    }

    public void tidur()
    {
        if(mainm.Instance.paper_infactory > 0)
        {
            mainm.Instance.kertas_infactory += mainm.Instance.paper_infactory;
            mainm.Instance.paper_infactory = 0;
        }
        if(mainm.Instance.leaf_infactory > 0)
        {
            mainm.Instance.pupuk_infactory += mainm.Instance.leaf_infactory;
            mainm.Instance.leaf_infactory = 0;
        }
        if(mainm.Instance.plastic_infactory > 0)
        {
            mainm.Instance.ember_infactory += mainm.Instance.plastic_infactory;
            mainm.Instance.plastic_infactory = 0;
        }
        

        mainm.Instance.sleep_paper = true;
        mainm.Instance.sleep_leaf = true;
        mainm.Instance.sleep_plas = true;

        mainm.Instance.day += 1;
        
        Time.timeScale = 1f;
        vidmulai = true;
    }

    public void noh()
    {
        sleepUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public void startvideo()
    {
        sleepUI.SetActive(false);
        videoUI.SetActive(true);
        yuai.itemUI.SetActive(false);
    }

    public void stopvideo()
    {
        sleepUI.SetActive(true);
        videoUI.SetActive(false);
        yuai.itemUI.SetActive(true);
        Time.timeScale = 1f;
        taim = 1.8f;
    }
}
