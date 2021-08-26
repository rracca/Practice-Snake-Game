using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class SnakeBodyPool : MonoBehaviour
{
    private Queue<SpriteRenderer> snakeBodySpriteQueue;

    private static SnakeBodyPool instance = null;
    public static SnakeBodyPool snakeBodyPoolInstance
    {
        get
        {
            if (instance == null)
                instance = new SnakeBodyPool();
            return instance;
        }
    }

    public SnakeBodyPool ()
    {
        DontDestroyOnLoad(this);
        InitializeSnakeBodyList();
    }

    private void InitializeSnakeBodyList ()
    {
        if (GameManager.GetInstance.GetBoardSize() != -1)
        {
            for (int counter = 0; counter < GameManager.GetInstance.GetBoardSize(); counter++)
            {
                snakeBodySpriteQueue.Enqueue(GameManager.GetInstance.SnakeBodySprite);
            }
        }
        else
            Debug.Log("Invalid Board Size.");
    }

    public SpriteRenderer GetSnakeBodySpriteRenderer()
    {
        return snakeBodySpriteQueue.Dequeue();
    }

    public void ReturnSnakeBodySpriteRenderer(SpriteRenderer snakeBodySpriteRenderer)
    {
        snakeBodySpriteQueue.Enqueue(snakeBodySpriteRenderer);
    }
}
