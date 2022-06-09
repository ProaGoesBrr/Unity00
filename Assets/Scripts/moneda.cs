using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneda : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(200f * Time.deltaTime, Random.Range(-200f, 200f) * Time.deltaTime, Random.Range(-200f, 200f) * Time.deltaTime, Space.World);
    }
}
