using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject moneda;
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Instantiate(moneda,new Vector3(Random.Range(-48,48), 0.5f,Random.Range(-48,48)),Quaternion.identity);
        }
    }

    void Update()
    {
        
    }
}
