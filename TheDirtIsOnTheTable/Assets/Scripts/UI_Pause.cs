using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UI_Pause : MonoBehaviour
{

    GameManager gm;
    public AudioClip clickSound;


    private void OnEnable()
    {
        gm = GameManager.GetInstance();
    }

    public void setPause()
    {
        Time.timeScale = 0;
        gm.ChangeState(GameManager.GameState.PAUSE);
    }

    public void Retornar()
    {
        IngameAudioManager.PlaySFX(clickSound);

        Time.timeScale = 1;
        gm.ChangeState(GameManager.GameState.GAME);
    }

    public void Inicio()
    {
        IngameAudioManager.PlaySFX(clickSound);

        Time.timeScale = 1;
        gm.Reset();
        SceneManager.LoadScene("StartGameScene");
    }

}