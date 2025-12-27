using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ui : MonoBehaviour
{
    public GameObject mm;
    public GameObject mep;
    public GameObject yno;
    public GameObject cntrol;
    public GameObject itemUI;

    public Text hari;

    public Text peper;
    public Text fert;
    public Text paper;
    public Text bottle;
    public Text ember;
    public Text fruit;
    public Text money;

    public bool pindah;
    public int scene_num = 0;
    public Scene scene_name;
    public Button yesbutton;
    public string[] cektmpt = new string[] { "factory", "city", "pasar", "school" };

    private loadscene ls;

    public bool savepause;

    // Start is called before the first frame update
    void Start()
    {
        savepause = false;

        hari.text = "Day " + (mainm.Instance.day.ToString());

        Time.timeScale = 1f;
        mm.SetActive(false);
        mep.SetActive(false);
        yno.SetActive(false);
        cntrol.SetActive(false);
        itemUI.SetActive(true);
        pindah = false;

        ls = FindObjectOfType<loadscene>();
    }

    // Update is called once per frame
    void Update()
    {
        hari.text = "Day " + mainm.Instance.day.ToString();
        scene_name = SceneManager.GetActiveScene();
        
        if (Input.GetButtonDown("Fire2")){
            Time.timeScale = 0f;
            mm.SetActive(true);
            savepause = true;
            DataPersistenceManager.Instance.SaveGame();
        }

        if (pindah == true)
        {
            ls.sceneload(scene_num);
        }

        try
        {
            if (scene_name.name == cektmpt[scene_num - 1])
            {
                yesbutton.enabled = false;
            }
        }
        catch
        {
            yesbutton.enabled = true;
        }

        peper.text = mainm.Instance.trash_paper.ToString();
        fruit.text = mainm.Instance.trash_leaf.ToString();
        bottle.text = mainm.Instance.trash_plastic.ToString();
        paper.text = mainm.Instance.papernew.ToString();
        ember.text = mainm.Instance.bucket.ToString();
        fert.text = mainm.Instance.fertiz.ToString();
        money.text = mainm.Instance.duit.ToString() + "$";

    }

    public void peta()
    {
        mm.SetActive(false);
        mep.SetActive(true);
    }

    public void ctrl()
    {
        mm.SetActive(false);
        cntrol.SetActive(true);
    }
    public void kluar()
    {
        Time.timeScale = 1f;
        mm.SetActive(false);
    }

    public void kuit()
    {
        Application.Quit();
    }

    public void balik()
    {
        mm.SetActive(true);
        mep.SetActive(false);
        cntrol.SetActive(false);
    }

    public void beskem()
    {
        yno.SetActive(true);
        scene_num = 1;
    }

    public void kota()
    {
        yno.SetActive(true);
        scene_num = 2;
    }
    public void blanja()
    {
        yno.SetActive(true);
        scene_num = 3;
    }
    public void skul()
    {
        yno.SetActive(true);
        scene_num = 4;
    }

    public void iya()
    {
        yno.SetActive(true);
        pindah = true;
        DataPersistenceManager.Instance.LoadGame();
    }
    public void tydac()
    {
        yno.SetActive(false);
        scene_num = 0;
    }

}
