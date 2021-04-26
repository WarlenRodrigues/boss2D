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
            case "Level4":
                gm.setCurrentLevel(4);
                SceneManager.LoadScene("Level_4");
                break;
            case "Level5":
                gm.setCurrentLevel(5);
                SceneManager.LoadScene("Level_5");
                break;
            case "Level6":
                gm.setCurrentLevel(6);
                SceneManager.LoadScene("Level_6");
                break;
            case "Level7":
                gm.setCurrentLevel(7);
                SceneManager.LoadScene("Level_7");
                break;
            case "Level8":
                gm.setCurrentLevel(8);
                SceneManager.LoadScene("Level_8");
                break;
            case "Level9":
                gm.setCurrentLevel(9);
                SceneManager.LoadScene("Level_9");
                break;
        }
    }

}
