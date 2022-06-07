using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject moneda;

    void Start()
    {
        for (int i = 0; i < 20; i++){
            Instantiate(moneda, new Vector3(Random.Range(-5, 5), 2, Random.Range(-5, 5)), Quaternion.identity);
        }
    }

    void Update()
    {                                      
//        aca porque se repite muchas veces 0 0 
    }
}
