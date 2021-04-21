using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelsSpawner : MonoBehaviour
{
    public GameObject LevelButton;
    public GameObject levelHolder;

    public int zeroXRender = 0;
    public int zeroYRender = 0;


    void Start()
    {
        Construir();
    }

    void Construir()
    {
        int levelNumber = 0;
        Rect panelDimensions = levelHolder.GetComponent<RectTransform>().rect;
        Rect buttonDimensions = LevelButton.GetComponent<RectTransform>().rect;

        Debug.Log(panelDimensions);
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Vector3 posicao = new Vector3((-panelDimensions.x + buttonDimensions.width / 2) + 80f * i, -panelDimensions.y - 40f * j);
                GameObject level = Instantiate(LevelButton, posicao, Quaternion.identity, transform);
                level.name = "Level" + levelNumber;
                level.GetComponentInChildren<Text>().text = "Level " + (1 + i + j + levelNumber);
            }
        }
    }

    void Update()
    {
    }

}
