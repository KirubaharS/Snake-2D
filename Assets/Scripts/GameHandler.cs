using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField]
    private Snake snake;
    private LevelGrid levelGrid;
    void Start()
    {
        Debug.Log("GameAsset.start");
        if (GameAssets.Instance == null)
        {
            Debug.LogError("GameAssets.Instance is null!");
            return;
        }
        levelGrid = new LevelGrid(20, 20);
        snake.Setup(levelGrid);
        levelGrid.Setup(snake);
    }

}
