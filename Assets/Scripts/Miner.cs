using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miner : BasePlayerClass
{

    protected override string getClassName()
    {
        return "Miner";
    }
    
    protected override Sprite getClassSprite()
    {
        return Resources.Load<Sprite>("Sprites/axe_t_06");
    }
}
