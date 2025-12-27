using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    public float speed = 2f;
    public float norm = 2f;
    public float sprint = 5f;
    private Rigidbody rb;

    private stamina st;

    public bool iswalk = false;

    public GameObject idle;
    public GameObject walk;

    private factorygm fgm;

    public float xpos;
    public float ypos;
    public float zpos;

    public bool shiftpressed;
    private void Start()
    {
        
        rb = FindObjectOfType<Rigidbody>();
        st = FindObjectOfType<stamina>();
      

        st.stui.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        //run
        //rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, rb.velocity.y, Input.GetAxis("Vertical") * speed);
        float horizonalinput = Input.GetAxis("Horizontal");
        float verticalinput = Input.GetAxis("Vertical");

        //arah


        Vector3 movedir = new Vector3(horizonalinput, 0, verticalinput);
        movedir.Normalize();

        transform.Translate(movedir * speed * Time.deltaTime, Space.World);

        if(movedir != Vector3.zero)
        {
            xpos = walk.transform.position.x;
            ypos = walk.transform.position.y;
            zpos = walk.transform.position.z;

            transform.forward = movedir;
            idle.SetActive(false);
            walk.SetActive(true);
            idle.transform.position = new Vector3(xpos, ypos - 0.199604f, zpos) ;
            idle.transform.rotation = walk.transform.rotation;
        }
        else
        {
            idle.SetActive(true);
            walk.SetActive(false);
            walk.transform.position = idle.transform.position;
            walk.transform.rotation = idle.transform.rotation;
        }

        
        

        //Stamina
        if (Input.GetButtonDown("Fire1") && st.curstamina > 0)
        {
            speed = sprint;
            st.sprint();
            shiftpressed = true;

        }
        else if (Input.GetButtonUp("Fire1") || st.curstamina <= 0 && st.stempty == false)
        {
            speed = norm;
            st.stand();
            shiftpressed = false;

        }
     
    }



}
