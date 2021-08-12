using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUIHandler : MonoBehaviour
{

    public void MinerSelected()
    {
        DataManager.instance.playerClass = "miner";
        SceneManager.LoadScene(1);
    }
    
    public void LumberjackSelected()
    {
        DataManager.instance.playerClass = "lumberjack";
        SceneManager.LoadScene(1);
    }
}
