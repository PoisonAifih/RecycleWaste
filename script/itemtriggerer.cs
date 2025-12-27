using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemtriggerer : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "paper")
        {
            mainm.Instance.trash_paper += 1;
            if (mainm.Instance.sleep_paper == true)
            {
                mainm.Instance.sleep_paper = false;
            }
        }

        if (collision.gameObject.tag == "botol")
        {
            if (mainm.Instance.sleep_plas == true)
            {
                mainm.Instance.sleep_plas = false;
            }
            mainm.Instance.trash_plastic += 1;
        }

        if (collision.gameObject.tag == "veg")
        {
            mainm.Instance.trash_leaf += 1;
            if (mainm.Instance.sleep_leaf == true)
            {
                mainm.Instance.sleep_leaf = false;
            }
        }
    }
}
