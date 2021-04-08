using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonScript : MonoBehaviour
{

    GameManager gm;


    public void selectLevels() {
        gm = GameManager.GetInstance();
        gm.ChangeState(GameManager.GameState.GAME);
        SceneManager.LoadScene("StartGameScene");
    }
}
