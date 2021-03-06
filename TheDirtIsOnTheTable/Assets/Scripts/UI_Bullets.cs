using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UI_Bullets : MonoBehaviour
{

    Text textComp;
    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        textComp = GetComponent<Text>();
        gm = GameManager.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.bullets >= 0 && textComp)
        {   
            textComp.text = $"{gm.bullets - 1}";
        }
    }

}