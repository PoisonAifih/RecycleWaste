using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noMusic : MonoBehaviour
{
    AudioSource ad;
    // Start is called before the first frame update
    void Start()
    {
        ad = GetComponent<AudioSource>();

        if (!ad.isPlaying)
        {
            ad.Play();
        }
        else if (ad.isPlaying)
        {
            ;
        }
    }

}
