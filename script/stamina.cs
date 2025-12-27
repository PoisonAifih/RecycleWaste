using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class stamina : MonoBehaviour
{
    public Slider staminabar;
    private playercontrol pc;
    public GameObject stui;

    private Scene sn;

    public float curstamina;
    private float maxstamina = 10f;

    public static stamina instance;

    public bool stempty = false;
    public bool isistm = false;
    private bool stamup = false;
    private bool shiftpress;

    // Start is called before the first frame update

    private void Awake()
    {
        sn = SceneManager.GetActiveScene();
        instance = this;
        pc = FindObjectOfType<playercontrol>();

    }
    void Start()
    {
        curstamina = maxstamina;
        staminabar.maxValue = maxstamina;
        staminabar.value = maxstamina;

        pc = FindObjectOfType<playercontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        staminabar.value = curstamina;

        if (curstamina > 10)
        {
            curstamina = 10;
        }

        if (curstamina == 10)
        {
            stui.SetActive(false);
            StopCoroutine(plusstam());
            StopCoroutine(usestam());
            stempty = false;
            isistm = false;
            stamup = false;

        }


        if (curstamina <= 0 || stamup == true || !stui.activeSelf || stempty == true)
        {
            pc.speed = 2;
        
        } 


    }

    public IEnumerator usestam()
    {
        /*
        curstamina -= 1;
        stamup = false;
        StopCoroutine(plusstam());
        if (curstamina > 0 && isistm == false)
        {
            yield return new WaitForSeconds(1);
            StartCoroutine(usestam());
            StopCoroutine(plusstam());
        }
        else if (curstamina <= 0 && shiftpress == false)
        {
            stempty = true;
            yield return new WaitForSeconds(3);
            StartCoroutine(plusstam());
            StopCoroutine(usestam());
            stamup = true;
        }*/

        while(curstamina > 0 && shiftpress == true)
        {
            curstamina -= 1;
            yield return new WaitForSeconds(1);
            StopCoroutine(plusstam());
        }

        if (shiftpress == false || curstamina <= 0 && shiftpress == false)
        {
            yield return new WaitForSeconds(3);
            StartCoroutine(plusstam());
            StopCoroutine(usestam());
        }

    }
    public IEnumerator plusstam()
    {
        /*
        if(shiftpress == false)
        {
            stamup = true;
            StopCoroutine(usestam());
            isistm = true;
            curstamina += 1;

            if (curstamina < 10)
            {
                yield return new WaitForSeconds(1);
                StartCoroutine(plusstam());
                StopCoroutine(usestam());
            }
        }*/

        while(curstamina < 10 && shiftpress == false)
        {
            StopCoroutine(usestam());

            curstamina += 1;
            yield return new WaitForSeconds(1);
        }
        if(curstamina == 10)
        {
            StopAllCoroutines();
        }
     }


    public void sprint()
    {
        shiftpress = true;
        stui.SetActive(true);
        StartCoroutine(usestam());
        StopCoroutine(plusstam());
        //isistm = false;
    }

    public void stand()
    {
        shiftpress = false;
        StopCoroutine(usestam());
        StartCoroutine(plusstam());

    }

}
