using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSelectScript : MonoBehaviour
{

    public void selectScene() {
        switch (this.gameObject.name)
        {
            case "Level1Button":
                SceneManager.LoadScene("Level_1");
                break;
            case "Level2Button":
                SceneManager.LoadScene("Level_2");
                break;
            case "Level3Button":
                SceneManager.LoadScene("Level_3");
                break;

        }
    }

}
