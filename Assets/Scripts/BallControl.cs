using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    public int speed;
    public int point;
    public Rigidbody physics;
    public int numberOfObject;
    public Text pointText;
    public Text finishText;
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
        //Destroy(other.gameObject); çok veri yediği için tercih edilmez, eğer tekrar kullanılacaksa obje 
        other.gameObject.SetActive(false); // optimizasyon için daga sağlıklı
        //point += 1;
        point++;
        //Debug.Log("Counter = " + point);
        pointText.text = "Point: " + point;

        if (point == numberOfObject)
        {
            //Debug.Log("Oyun Bitti!");
            finishText.gameObject.SetActive(true);
        }
    }
}
