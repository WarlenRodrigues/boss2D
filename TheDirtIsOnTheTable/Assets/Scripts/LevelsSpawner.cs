using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelsSpawner : MonoBehaviour
{
    public GameObject LevelButton;
    public GameObject levelHolder;



    void Start()
    {
        Construir();
    }

    void Construir()
    {
        int levelNumber = 1;
        Rect panelDimensions = levelHolder.GetComponent<RectTransform>().rect;
        Rect buttonDimensions = LevelButton.GetComponent<RectTransform>().rect;

        float unitSlot = panelDimensions.width / 12;
        LevelButton.GetComponent<RectTransform>().sizeDelta = new Vector2(3 * unitSlot, buttonDimensions.height);

        float zeroX = -panelDimensions.x + (buttonDimensions.width / 2) + unitSlot;

        float zeroY = -panelDimensions.y;

        for (int i = 0; i < 3; i++)
        {
            int howManyButtons = 0;
            for (int j = 0; j < 3; j++)
            {
                Vector3 posicao = new Vector3(zeroX + (3 * unitSlot * howManyButtons) + (unitSlot * howManyButtons), zeroY - 40f * i);
                GameObject level = Instantiate(LevelButton, posicao, Quaternion.identity, transform);
                level.name = "Level" + levelNumber;
                level.GetComponentInChildren<Text>().text = "Level " + levelNumber;
                levelNumber++;
                howManyButtons++;
            }
        }
    }

    void Update()
    {
    }

}
