using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelsSpawner : MonoBehaviour
{
    public GameObject LevelButton;
    public GameObject levelHolder;

    GameManager gm;



    void Start()
    {
        gm = GameManager.GetInstance();

        Construir();
    }

    void Construir()
    {
        int levelNumber = 1;
        Rect panelDimensions = levelHolder.GetComponent<RectTransform>().rect;
        Rect buttonDimensions = LevelButton.GetComponent<RectTransform>().rect;

        float unitWidthSlot = panelDimensions.width / 13;
        float unitHeigthSlot = panelDimensions.height / 13;

        float maxHeigth = 20.0f;

        if (unitHeigthSlot < maxHeigth)
        {
            maxHeigth = unitHeigthSlot;
        }

        LevelButton.GetComponent<RectTransform>().sizeDelta = new Vector2(3 * unitWidthSlot, 2 * maxHeigth);

        float zeroX = -panelDimensions.x + (buttonDimensions.width / 2) + unitWidthSlot;
        float zeroY = -panelDimensions.y - unitHeigthSlot;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Vector3 posicao = new Vector3(zeroX + (3 * unitWidthSlot * j) + (unitWidthSlot * j), zeroY - (3 * unitHeigthSlot * i) - (unitHeigthSlot * i));
                GameObject level = Instantiate(LevelButton, posicao, Quaternion.identity, transform);
                level.name = "Level" + levelNumber;
                level.GetComponentInChildren<Text>().text = "Level " + levelNumber;
                if (levelNumber > gm.unlockedLevels)
                {
                    level.GetComponent<Button>().interactable = false;
                }
                levelNumber++;
            }
        }
    }

    void Update()
    {
    }

}
