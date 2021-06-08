using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public void Load_lvl_1()
    {
        The_Score.instance.ResetJSON();
        SceneManager.LoadScene(1);
    }

    public void Exit_game() 
    { 
        GameManager.instance.game_status = false;
        
        Application.Quit(); 
    }
    public void LoadNextLvl() 
    {
        Saver.instance.Save();
        int acticeScene = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = ++acticeScene;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings) { nextSceneIndex = 1; }
        SceneManager.LoadScene(nextSceneIndex);
    }
    public void Candy_Store()
    {

        //XXXX.instance.boolShowWinPanel = false;
        //XXXX.instance.Panel_Store.SetActive(true);
        XXXX.instance.StatusShowPanel(false);
        XXXX.instance.StatusPanelStore(true);
        Debug.Log("store button working");

    }
    public void LinkToInstagram()
    {
        Application.OpenURL("https://www.instagram.com/the_nem.s/");
    }

    public void LinkToPatreon()
    {
        Application.OpenURL("https://www.patreon.com/the_nem_s");
    }

    
}
