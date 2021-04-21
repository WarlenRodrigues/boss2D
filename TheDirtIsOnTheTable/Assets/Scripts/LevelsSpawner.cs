using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelsSpawner : MonoBehaviour
{
    public GameObject LevelButton;

    void Start()
    {
        Construir();
    }

    void Construir()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Vector3 posicao = new Vector3(80 + 80f * i, 160 - 40f * j);
                GameObject level = Instantiate(LevelButton, posicao, Quaternion.identity, transform);
                level.name = "Level" + (1 + i + j);
                level.GetComponentInChildren<Text>().text = "Level " + (1 + i + j);
            }
        }
    }

    void Update()
    {
    }

}
