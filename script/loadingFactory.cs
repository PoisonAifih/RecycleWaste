using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadingFactory : MonoBehaviour
{
    public Slider loadingbar;
    public Text[] tip;


    // Start is called before the first frame update
    void Start()
    {
        loadingbar.value = 0.1f; 
        this.gameObject.SetActive(true);

        StartCoroutine(loadbar());

        for (int i = 0; i <= 6; i++)
        {
            tip[i].gameObject.SetActive(false);
        }

        if (mainm.Instance.tipshow == false)
        {
            mainm.Instance.tiprand = (Random.Range(0, 6));
            
            mainm.Instance.tipshow = true;
        }
        tip[mainm.Instance.tiprand].gameObject.SetActive(true);

    }

    private void Update()
    {
        if (loadingbar.value >= 0.9)
        {
            this.gameObject.SetActive(false);
            tip[mainm.Instance.tiprand].gameObject.SetActive(false);
            mainm.Instance.tipshow = false;
        }
    }
    IEnumerator loadbar()
    {
        loadingbar.value += 0.05f;
        Debug.Log("+1");
        yield return new WaitForSeconds(0.1f);
        StartCoroutine(loadbar());

    }
}
