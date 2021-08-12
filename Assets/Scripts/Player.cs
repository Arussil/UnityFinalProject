using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string playerClass;
    private SpriteRenderer spriteRenderer;

    public Sprite miner;
    public Sprite lumberjack;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        playerClass = DataManager.instance.playerClass;    
        if (playerClass == "miner")
        {
            spriteRenderer.sprite = miner;
        }
        else if (playerClass == "lumberjack")
        {
            spriteRenderer.sprite = lumberjack;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
