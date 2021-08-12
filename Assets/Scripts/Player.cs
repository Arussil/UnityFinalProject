using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private BasePlayerClass playerClass;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        playerClass = DataManager.instance.playerClass;    
        spriteRenderer.sprite = playerClass.classSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
