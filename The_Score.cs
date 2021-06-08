using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class The_Score : MonoBehaviour
{
    public Saver save;
    // this Sc is for CANDY _____________!!!

    public static The_Score instance;
    
    private void Awake()
    {
        if (instance == null) { instance = this; }
        
    }


    public int Candy_score;
    public int Lifes_score = 3;

    //public int burgerCost = 60;
    //public int candyCost = 80;
    //public int coockyCost = 80;
    //public int meatCost = 100;
    //public int lifeCost = 100;    

    public int burgerCost;
    public int candyCost;
    public int coockyCost;
    public int meatCost;
    public int lifeCost;

    
    public GameObject Panel_GameOver;
    public GameObject Panel_Win_NextLevel;

    
    void Start()
    {


        Saver.instance.Load();


        burgerCost = 60;
        candyCost = 80;
        coockyCost = 80;
        meatCost = 100;
        lifeCost = 100;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.C)) { Candy_score += 9999;  Lifes_score =3;  Saver.instance.Save(); Debug.Log("cheat working"); }
        if (Input.GetKeyDown(KeyCode.F)) { ResetJSON(); }

    }
    public void LooseLive(int life) { Lifes_score += life; }    //Saver.instance.jsonLifesScore += life; Saver.instance.Save();
    public void CandyCalculation(int candy) { Candy_score += candy; }  //Saver.instance.jsonCandyScore += candy; Saver.instance.Save();
    public void ResetJSON() { Candy_score = 0; Lifes_score = 3; Saver.instance.Save(); Debug.Log("cheat working"); }

    public void BuyBurger()
    {
        if (burgerCost <Candy_score) { return; }
        Debug.Log("working");
        Spawn3.instance.AddBurgr();

        //The_Score.instance.Candy_score -= The_Score.instance.burgerCost;
        //Saver.instance.jsonCandyScore -= The_Score.instance.burgerCost;

        //Sc_Audio.instance.PlayBuyCandy();
        //Saver.instance.Save();
    }

    public void BuyCandy()
    {
        if (candyCost < Candy_score) { return; }
        Spawn3.instance.AddCandy();
        Candy_score -= candyCost;
        //Saver.instance.jsonCandyScore -= The_Score.instance.candyCost;
        Sc_Audio.instance.PlayBuyCandy();
        //Saver.instance.Save();
    }
    public void BuyCoocke()
    {
        if (The_Score.instance.coockyCost < The_Score.instance.Candy_score) { return; }
        Spawn3.instance.AddCoocke();
        Candy_score -= coockyCost;
        //Saver.instance.jsonCandyScore -= The_Score.instance.coockyCost;
        Sc_Audio.instance.PlayBuyCandy();
        //Saver.instance.Save();
    }
    public void BuyMeat()
    {
        if (The_Score.instance.meatCost < The_Score.instance.Candy_score) { return; }
        Spawn3.instance.AddMeat();
        Candy_score -= meatCost;
        //Saver.instance.jsonCandyScore -= The_Score.instance.meatCost;
        Sc_Audio.instance.PlayBuyCandy();
        //Saver.instance.Save();
    }

    public void BuyLife()
    {
        if (lifeCost <Candy_score) { return; }
        if (Lifes_score == 3) { return; }
        if (Lifes_score == 2) { GameManager.instance.AAA_Lives.transform.GetChild(2).gameObject.SetActive(true); Candy_score -= lifeCost; } //Saver.instance.Save();Saver.instance.jsonCandyScore -= The_Score.instance.lifeCost;
        if (Lifes_score == 1) { GameManager.instance.AAA_Lives.transform.GetChild(1).gameObject.SetActive(true); Candy_score -= lifeCost; }
        if (Lifes_score == 0) { GameManager.instance.AAA_Lives.transform.GetChild(0).gameObject.SetActive(true); Candy_score -= lifeCost; }
    }

}
