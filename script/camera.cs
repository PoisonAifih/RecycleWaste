using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class camera : MonoBehaviour
{
    private playercontrol pc;
    private Vector3 offset;
    private Scene sn;

    // Start is called before the first frame update
    void Start()
    {
        sn = SceneManager.GetActiveScene();
        pc = FindObjectOfType<playercontrol>();
        offset = transform.position - pc.transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        sn = SceneManager.GetActiveScene();
        transform.position = pc.transform.position + offset;


    }
}
