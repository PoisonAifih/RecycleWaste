using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laodingscene : MonoBehaviour
{
    public static laodingscene Instance;

    public GameObject loadingmenu;
      
    // Start is called before the first frame update
    private void Awake()
    {
        loadingmenu = this.gameObject;

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
