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
                SceneManager.LoadScene("Transition2");
                break;
            case "Level3Button":
                SceneManager.LoadScene("Transition3");
                break;

        }
    }

}
