using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    public static GameAssets Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.LogError("More than one GameAssets instance!");
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    //private void Awake()
    //{
       // if (Instance != null)
      //  {
       //     Debug.LogError("More than one GameAssets instance!");
         //   Destroy(gameObject);
       //     return;
      //  }
     //   Instance = this;
  //  }
    public Sprite snakeHeadSprite;
    public Sprite foodSprite;
}
