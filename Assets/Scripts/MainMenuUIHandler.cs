using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUIHandler : MonoBehaviour
{

    public void MinerSelected()
    {
        DataManager.instance.playerClass = new Miner();
        SceneManager.LoadScene(1);
    }
    
    public void LumberjackSelected()
    {
        DataManager.instance.playerClass = new Lumberjack();
        SceneManager.LoadScene(1);
    }
}
