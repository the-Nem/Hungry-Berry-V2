using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if (instance == null) { instance = this; }
    }


    public bool game_status = false;
    public bool boolGameOverPanel = false;
    public bool boolPanel_Win_NextLevel = false;

    public GameObject AAA_Lives;
    public Text Panel_text;




    void Start()
    {
        game_status = true; //___________________________________________________
    }

    void Update()
    {
       
        if (game_status == true)
        {
            Player_1.instance.Movement();              
        }
        
        InGameLifeCount();
        Panel_text.text = The_Score.instance.Candy_score.ToString();



    }

    public void Game_is_on()
    {


        AAA_Lives.transform.GetChild(0).gameObject.SetActive(false);

        Player_1.instance.Movement(); // MOVEMENT WORKS!!!!


    }
    public void InGameLifeCount()
    {
        if (The_Score.instance.Lifes_score == 2) { AAA_Lives.transform.GetChild(2).gameObject.SetActive(false); }
        if (The_Score.instance.Lifes_score == 1) { AAA_Lives.transform.GetChild(1).gameObject.SetActive(false); }
        if (The_Score.instance.Lifes_score == 0) { AAA_Lives.transform.GetChild(0).gameObject.SetActive(false); }

    }




}
