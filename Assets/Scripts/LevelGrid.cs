using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGrid
{
    private Vector2Int foodGridPosition;
    private GameObject foodGameObject;
    private int width;
    private int height;
    private Snake snake;

    public LevelGrid(int width, int height)
    {
        this.width = width;
        this.height = height;
        SpawnFood();
    }

    public void Setup(Snake snake)
    {
        this.snake = snake;
    }

    private void SpawnFood()
    {
        if (GameAssets.Instance == null)
        {
            Debug.LogError("GameAssets.Instance is null! Cannot spawn food.");
            return;
        }
        do
        {
            foodGridPosition = new Vector2Int(Random.Range(0, width), Random.Range(0, height));
        } while (snake.GetGridPosition() == foodGridPosition);
        
        foodGameObject = new GameObject("Food", typeof(SpriteRenderer));
        foodGameObject.GetComponent<SpriteRenderer>().sprite = GameAssets.Instance.foodSprite;
        foodGameObject.transform.position = new Vector3(foodGridPosition.x, foodGridPosition.y);
    }

    public void SnakeMoved(Vector2Int snakeGridPosition)
    {
        if (snakeGridPosition == foodGridPosition)
        {
            Object.Destroy(foodGameObject);
            SpawnFood();
            Debug.Log("snake ate food");
        }
    }
}
