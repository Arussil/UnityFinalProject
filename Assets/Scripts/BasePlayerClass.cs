using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class BasePlayerClass
{
    public string className {get; set;}
    public Sprite classSprite {get; set;}

    public BasePlayerClass()
    {
        className = getClassName();
        classSprite = getClassSprite();
    }

    abstract protected string getClassName();
    
    abstract protected Sprite getClassSprite();

}
