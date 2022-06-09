using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Rigidbody rb;
    public int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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

/*
        switch(Event.current.isKey) 
        {
            case "w":
            rb.AddForce(0, 0, 1 * speed * Time.deltaTime, ForceMode.Force);
                    rb.drag = 0;
                    rb.angularDrag = 0.05f;
                break;
            case "s":
                    rb.AddForce(0, 0, -1 * speed * Time.deltaTime, ForceMode.Force);
                    rb.drag = 0;
                    rb.angularDrag = 0.05f;   
                break;
                case "a":
                    rb.AddForce(-1 * speed * Time.deltaTime, 0, 0, ForceMode.Force);
                    rb.drag = 0;
                    rb.angularDrag = 0.05f;   
                break;
                case "d":
                    rb.AddForce(1 * speed * Time.deltaTime, 0, 0, ForceMode.Force);
                    rb.drag = 0;
                    rb.angularDrag = 0.05f;    
                break;
            default:
                    rb.drag = 5;
                    rb.angularDrag = 2;
                break;
        }
*/