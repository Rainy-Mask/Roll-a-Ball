using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public int speed;
    public Rigidbody physics;
    void Start()
    {
        physics = GetComponent<Rigidbody>();
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

        Vector3 vector = new Vector3(horizontal, 0, vertical);

        physics.AddForce(vector * speed);
        Debug.Log(transform.position);
        
        //Debug.Log("horizontal " + horizontal); //yatay
        //Debug.Log("vertical " + vertical); //dikey
        
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
