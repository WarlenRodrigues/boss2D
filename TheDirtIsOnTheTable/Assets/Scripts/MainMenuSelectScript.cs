using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSelectScript : MonoBehaviour
{
    GameManager gm;
    public AudioClip clickSound;


    void Start()
    {
        gm = GameManager.GetInstance();
    }

    public void selectScene()
    {
        IngameAudioManager.PlaySFX(clickSound);

        switch (this.gameObject.name)
        {
            case "Level1":
                gm.setCurrentLevel(1);
                SceneManager.LoadScene("Level_1");
                break;
            case "Level2":
                gm.setCurrentLevel(2);
                SceneManager.LoadScene("Level_2");
                break;
            case "Level3":
                gm.setCurrentLevel(3);
                SceneManager.LoadScene("Level_3");
                break;

        }
    }

}
