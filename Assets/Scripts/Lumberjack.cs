using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lumberjack : BasePlayerClass
{

    protected override string getClassName()
    {
        return "Lumberjack";
    }
    
    protected override Sprite getClassSprite()
    {
        return Resources.Load<Sprite>("Sprites/axe_t_09");
    }
}
