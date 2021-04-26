using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager
{

    public enum GameState { GAME, PAUSE, ENDGAMEWIN, ENDGAMELOST };

    public GameState gameState { get; private set; }
    public int unlockedLevels;
    public int pontos;
    public int bullets;
    public int currentLevel;

    public delegate void ChangeStateDelegate();
    public static ChangeStateDelegate changeStateDelegate;

    private static GameManager _instance;

    public static GameManager GetInstance()
    {
        if (_instance == null)
        {
            _instance = new GameManager();
        }

        return _instance;
    }

    private GameManager()
    {
        currentLevel = 1;
        unlockedLevels = currentLevel;
        pontos = 0;
        gameState = GameState.GAME;
        bullets = 0;
    }

    public void ChangeState(GameState nextState)
    {
        gameState = nextState;
        changeStateDelegate();
    }

    public void Reset()
    {
        pontos = 0;
        bullets = 0;
        gameState = GameState.GAME;
    }

    public void PassLevel()
    {
        if (unlockedLevels > 9)
        {
            SceneManager.LoadScene("FinishGameScene");
        }

        if (currentLevel == unlockedLevels)
        {
            unlockedLevels++;
        }
    }

    public void lost()
    {
        if (gameState != GameState.ENDGAMEWIN)
        {
            Debug.Log("LOST");
            Debug.Log(gameState);
            Target.TargetsOverTheTable = 0;
            ChangeState(GameState.ENDGAMELOST);
        }
    }

    public void win()
    {
        Debug.Log("WIN");
        Target.TargetsOverTheTable = 0;
        ChangeState(GameState.ENDGAMEWIN);
        PassLevel();
    }

    public void setCurrentLevel(int level)
    {
        currentLevel = level;
    }

}