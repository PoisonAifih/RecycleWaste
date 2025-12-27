using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factorybg : MonoBehaviour
{
    public static factorybg Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public IEnumerator paper_fac()
    {
        yield return new WaitForSeconds(30);


        if (mainm.Instance.paper_infactory > 0)
        {
            mainm.Instance.kertas_infactory += 1;
            mainm.Instance.paper_infactory -= 1;
            StartCoroutine(paper_fac());
        }
        else
        {
            yield return null;
        }
    }
    public IEnumerator leaf_fac()
    {
        yield return new WaitForSeconds(60);


        if (mainm.Instance.leaf_infactory > 0)
        {
            mainm.Instance.pupuk_infactory += 1;
            mainm.Instance.leaf_infactory -= 1;
            StartCoroutine(leaf_fac());
        }
        else
        {
            yield return null;
        }
    }
    public IEnumerator plas_fac()
    {
        yield return new WaitForSeconds(120);


        if (mainm.Instance.plastic_infactory > 0)
        {
            mainm.Instance.ember_infactory += 1;
            mainm.Instance.plastic_infactory -= 1;
            StartCoroutine(plas_fac());
        }
        else
        {
            yield return null;
        }
    }
}
