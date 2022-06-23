using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public int speed = 40;
    public int android_speed = 1000;
    public int points = 0;


    void FixedUpdate()
    {
        if (SystemInfo.deviceType == DeviceType.Desktop)
            PC_Movement();

        else 
            Android_Movement();
    }

        void OnCollisionEnter(Collision other){
            if(other.gameObject.tag == "enemy"){
                gameObject.SetActive(false);
                // Time.timeScale = 0f;
            }
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Moneda")
            {
                points++;
                Destroy(other.gameObject);
            }
        }



    public void Android_Movement()
    {
        Vector3 movement = new Vector3 (Input.acceleration.x, 0.0f, Input.acceleration.y);
        GetComponent<Rigidbody>().AddForce(movement * android_speed * Time.deltaTime);
    }



    public void PC_Movement(){
        if (Input.GetKey("w")){
            rb.AddForce(0, 0, 1 * speed * Time.deltaTime, ForceMode.Force);
            rb.drag = 0;
            rb.angularDrag = 0.05f;
        }
        if (Input.GetKey("s")){
            rb.AddForce(0, 0, -1 * speed * Time.deltaTime, ForceMode.Force);
            rb.drag = 0;
            rb.angularDrag = 0.05f;            
        }
        if (Input.GetKey("a")){
            rb.AddForce(-1 * speed * Time.deltaTime, 0, 0, ForceMode.Force);
            rb.drag = 0;
            rb.angularDrag = 0.05f;            
        }
        if (Input.GetKey("d")){
            rb.AddForce(1 * speed * Time.deltaTime, 0, 0, ForceMode.Force);
            rb.drag = 0;
            rb.angularDrag = 0.05f;            
        }
        if (!Input.anyKey){
            rb.drag = 8;
            rb.angularDrag = 4;
        }
    }
}
