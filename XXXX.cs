using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class XXXX : MonoBehaviour
{
    public Saver save;
    public static XXXX instance;
    private void Awake()
    {
        if (instance == null) { instance = this; }
    }
    public GameObject Panel_GameOver;
    public GameObject Panel_Win_NextLevel;    
    public GameObject Panel_Score;
    public GameObject Panel_Store;

    public int quantityDestroedCandys = 0;
    public int quantityEatedCandys = 0;

    public int Summ;
    public int maxCandyQuantityInLvl = 6;

    public bool boolShowWinPanel = true;
    public bool boolShowStore = true;
    private bool boolMaxCandy = false;


    void Start()
    {




    }
    void Update()
    {
        Summ = quantityEatedCandys + quantityDestroedCandys;

        if (The_Score.instance.Lifes_score == 0) 
        {
            Sc_Audio.instance.PlayGameOver();
            GameManager.instance.game_status = false;
            Panel_GameOver.SetActive(true);
            Debug.Log("game_status false becouse life");
            The_Score.instance.ResetJSON();
            Sc_Audio.instance.PlayGameOver();
        }

        if (Summ == maxCandyQuantityInLvl) { boolMaxCandy = true; }
        if(boolMaxCandy)
        {
            Sc_Audio.instance.PlayWin();
            Saver.instance.Save();
            GameManager.instance.game_status = false;

            Panel_Win_NextLevel.SetActive(boolShowWinPanel);

            Debug.Log("game_status =  no more candy");
            quantityDestroedCandys = 0;
            boolMaxCandy = false;


        }



    }
        //public void StatusPanel_Win_NextLevel(bool status) { Panel_Win_NextLevel.SetActive(status); }

    public void AffectToEatedCandys(int candy) { quantityEatedCandys += candy; }
    public void AffectToDestroedCandys(int candy) { quantityDestroedCandys += candy; }
    public void StatusShowPanel(bool on_off) { Panel_Win_NextLevel.SetActive(on_off); }
    public void StatusPanelStore(bool on_off) { Panel_Store.SetActive(on_off); }


}