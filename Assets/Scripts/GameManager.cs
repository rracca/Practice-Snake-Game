using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameManager : MonoBehaviour
{
    [SerializeField] private SpriteRenderer snakeHeadSprite;
    [SerializeField] private SpriteRenderer snakeBodySprite;
    [SerializeField] private SpriteRenderer board;

    private static GameManager instance = null;
    public static GameManager GetInstance
    {
        get
        {
            if (instance == null)
                instance = new GameManager();
            return instance;
        }
    }

    public GameManager ()
    {
        DontDestroyOnLoad(this);
    }

    public SpriteRenderer SnakeHeadSprite
    {
        get
        {
            return snakeHeadSprite;
        }
    }

    public SpriteRenderer SnakeBodySprite
    {
        get
        {
            return snakeBodySprite;
        }
    }

    public int GetBoardSize()
    {
        if (board != null)
        {
            float boardWidth = board.transform.localScale.x;
            float boardHeight = board.transform.localScale.y;

            if (boardWidth % 2 == 0 && boardHeight % 2 == 0)
                return (int)((boardWidth / 2) * (boardHeight / 2));
            else
                Debug.Log("Board Width: " + boardWidth + "\nBoard Height: " + boardHeight + "\nInvalid Width/Height.");
                return -1;
        }
        else
        {
            Debug.Log("No Board Assigned.");
            return -1;
        }
    }
}
