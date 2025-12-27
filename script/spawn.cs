using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawn : MonoBehaviour
{
    public GameObject item;
    public Scene scene_name;


    // Start is called before the first frame update
    void Start()
    {

        scene_name = SceneManager.GetActiveScene();
        
        if (mainm.Instance.sleep_paper == true && scene_name.name == "school" && mainm.Instance.opdone == true)
        {
            spawnobject();
        }
        if (mainm.Instance.sleep_leaf == true && scene_name.name == "pasar" && mainm.Instance.opdone == true)
        {
            spawnobject();
        }
        if (mainm.Instance.sleep_plas == true && scene_name.name == "city" && mainm.Instance.opdone == true)
        {
            spawnobject();
        }
        else if (mainm.Instance.sleep_paper == false && scene_name.name == "school" && mainm.Instance.opdone == true)
        {
            StartCoroutine(manual_spawn());
        }
        else if (mainm.Instance.sleep_leaf == false && scene_name.name == "pasar" && mainm.Instance.opdone == true)
        {
            StartCoroutine(manual_spawn());
        }
        else if (mainm.Instance.sleep_plas == false && scene_name.name == "city" && mainm.Instance.opdone == true)
        {
            StartCoroutine(manual_spawn());
        }

    }

    public void spawnobject()
    {
        for (int i = 0; i < 20; i++)
        {
            Vector3 randomSpawnPos = new Vector3(Random.Range(-32, 32), -1, Random.Range(-32, 32));
            Instantiate(item, randomSpawnPos, Quaternion.identity);
        }
    }



    IEnumerator manual_spawn()
    {
        Vector3 randomSpawnPos = new Vector3(Random.Range(-32, 32), -1, Random.Range(-32, 32));
        Instantiate(item, randomSpawnPos, Quaternion.identity);
        yield return new WaitForSeconds(30);
        StartCoroutine(manual_spawn());
    }

}
