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
        unlockedLevels = 1;
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

    public void passLevel()
    {
        unlockedLevels++;
        // Reset();
    }

}