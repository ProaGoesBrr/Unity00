using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject moneda, bola_pinchuda;
    public TMP_Text texto;
    public PlayerController player;
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Instantiate(moneda,new Vector3(Random.Range(-48,48), 0.5f,Random.Range(-48,48)),Quaternion.identity);
        }
        for (int i = 0; i < 10; i++)
        {

            Instantiate(bola_pinchuda,new Vector3(Random.Range(-48,48), 2.32f,Random.Range(-48,48)),Quaternion.identity);
        }
    }

    void Update()
    {
        texto.text = player.points.ToString();
    }
}
