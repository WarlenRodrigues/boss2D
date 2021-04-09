using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UI_Pause : MonoBehaviour
{

    GameManager gm;

    private void OnEnable()
    {
        gm = GameManager.GetInstance();
    }

    public void setPause()
    {
        gm.ChangeState(GameManager.GameState.PAUSE);
    }

    public void Retornar()
    {
        gm.ChangeState(GameManager.GameState.GAME);
    }

    public void Inicio()
    {
        gm.ChangeState(GameManager.GameState.GAME);
        gm.Reset();
        SceneManager.LoadScene("StartGameScene");
    }

}