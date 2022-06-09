using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject moneda;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            Instantiate(moneda,new Vector3(Random.Range(-48,48),1,Random.Range(-48,48)),Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
