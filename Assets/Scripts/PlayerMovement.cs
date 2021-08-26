using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private List<SpriteRenderer> snake;

    void Start()
    {
        snake.Add(GameManager.GetInstance.SnakeHeadSprite);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            MoveSnake(KeyCode.UpArrow);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            MoveSnake(KeyCode.DownArrow);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            MoveSnake(KeyCode.LeftArrow);
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            MoveSnake(KeyCode.RightArrow);
    }

    void MoveSnake(KeyCode keyPressed)
    {
        SpriteRenderer snakeHead = snake[0];
        
        //while ()
        //{
        //    snakeHead.transform.
        //}
    }
}
