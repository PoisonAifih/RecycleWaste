using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gm_mm : MonoBehaviour
{
    public GameObject cntrol;
    public GameObject volum;

    private loadscene ls;

    // Start is called before the first frame update
    void Start()
    {
        ls = FindObjectOfType<loadscene>();

        cntrol.SetActive(false);
        volum.SetActive(false);
    }

    public void mulai()
    {
        ls.sceneload(1);
    }
    
    public void kuit()
    {
        Application.Quit();
    }

    public void suara()
    {
        volum.SetActive(true);
    }

    public void kntrl()
    {
        cntrol.SetActive(true);
    }
    public void balik()
    {
        volum.SetActive(false);
        cntrol.SetActive(false);
    }
}
