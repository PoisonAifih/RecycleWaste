using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollider_factory : MonoBehaviour
{
    private factorygm fgm;

    public bool istouching = false;

    private void Start()
    {
        fgm = FindObjectOfType<factorygm>();

        fgm.plasUI.SetActive(false);
        fgm.paperUI.SetActive(false);
        fgm.pupukUI.SetActive(false);
        fgm.sellUI.SetActive(false);
        fgm.sleepUI.SetActive(false);

        istouching = false;
    }
    private void OnTriggerEnter(Collider collider)
    {
        istouching = true;

        if (collider.gameObject.tag == "paper_fac")
        {
            fgm.paperUI.SetActive(true);
            fgm.touch = 1;
        }
        if (collider.gameObject.tag == "compost_fac")
        {
            fgm.pupukUI.SetActive(true);
            fgm.touch = 2;
        }
        if (collider.gameObject.tag == "plastic_fac")
        {
            fgm.plasUI.SetActive(true);
            fgm.touch = 3;
        }
        if (collider.gameObject.tag == "truck")
        {
            fgm.sellUI.SetActive(true);
            fgm.touch = 4;
        }
        if (collider.gameObject.tag == "house")
        {
            fgm.sleepUI.SetActive(true);
            fgm.touch = 5;
            Time.timeScale = 0f;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        istouching = false;

        fgm.plasUI.SetActive(false);
        fgm.paperUI.SetActive(false);
        fgm.pupukUI.SetActive(false);
        fgm.sellUI.SetActive(false);
        fgm.sleepUI.SetActive(false);
        fgm.touch = 0;
    }


}
