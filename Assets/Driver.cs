using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]
     float steerSpeed = 125;
     [SerializeField]
     float moveSpeed = 20;  
    [SerializeField] float slowDownAmount = 15.0f;
    [SerializeField] float speedUpAmount = 30.0f;        
    // Start is called before the first frame update
    void Start()
    {
       
        
    }
     void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Boost"){
            moveSpeed = speedUpAmount;
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
       
            moveSpeed = slowDownAmount;
         
    }

    // Update is called once per frame
    void Update()
    {
        var steerAmount = Input.GetAxis("Horizontal") * (steerSpeed * Time.deltaTime);
        var movAmount = Input.GetAxis("Vertical") * (moveSpeed * Time.deltaTime);
        transform.Rotate(0,0,-steerAmount); 
        transform.Translate(0,movAmount,0);
      
        
    }
}
