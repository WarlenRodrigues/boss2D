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
                SceneManager.LoadScene("ExampleScene");
                break;
            case "Level2Button":
                SceneManager.LoadScene("ExampleScene");
                break;
            case "Level3Button":
                SceneManager.LoadScene("ExampleScene");
                break;

        }
    }

}
