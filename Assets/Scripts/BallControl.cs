using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       //transform.Translate(0,0,10); 
    }

    // Update is called once per frame
    void FixedUpdate()
    { 
        //transform.Translate(0,0,10); 
        //transform.Rotate(0,0,-0.1f);
        /*if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("ESC tuşuna basıldı!");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E tuşuna basıldı!");
        }*/

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        
        Debug.Log("horizontal " + horizontal); //yatay
        Debug.Log("vertical " + vertical); //dikey



    }
}
