using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn3 : MonoBehaviour
{
    static List<GameObject> Feed = new List<GameObject>();

    private GameObject Bone;
    private GameObject Bone2;
    private GameObject Bone3;
    private GameObject Bone4;
    private GameObject Bone5;
    private GameObject Bone6;

    private GameObject Chili;
    private GameObject Burger;
    private GameObject Candy;
    private GameObject Coocke;
    private GameObject Meat;

    private int RandomCandy;
    public float candyFallSpeed = 0.5f;
    private float random_pos_spawnX;

    public float Timer = 0.35f;

    private int CandyFallCount = 0;

    bool candyCountBool = false;
    public static Spawn3 instance;
    private void Awake()
    {
        if (instance == null) { instance = this; }
     }

    // Start is called before the first frame update
    void Start()
    {
        candyCountBool = true;
        AssingObjToArray();

    }

    private void GiveMeCandy()
    {
        RandomCandy = Random.Range(0, Feed.Count);
        random_pos_spawnX = Random.Range(-7f, 7f);
        float posSpawnY = 11f;
        Vector2 random_pos_spawn = new Vector2(random_pos_spawnX, posSpawnY);
        Instantiate(Feed[RandomCandy], random_pos_spawn* candyFallSpeed, Quaternion.identity);
        ++CandyFallCount;
    }

    private void AssingObjToArray()
    {
        Chili = GameObject.Find("Chili1");
        Bone = GameObject.Find("Bone1");
        Bone2 = GameObject.Find("Bone2");

        Burger = GameObject.Find("Burger1");
        Bone3 = GameObject.Find("Bone3");

        Bone4 = GameObject.Find("Bone4");
        Candy = GameObject.Find("Candy1");

        Bone5 = GameObject.Find("Bone5");
        Coocke = GameObject.Find("Coocke1");

        Bone6 = GameObject.Find("Bone6");
        Meat = GameObject.Find("Meat1");


        //      Feed.Add(GameObject.Find("Bone1"));
        Feed.Add(Bone);
        Feed.Add(Chili);
        Feed.Add(Bone2);

        //Saver.instance.JsGameObj.Add(Bone);     not shour is good idea to comment this !! !! !! !! !!
        //Saver.instance.JsGameObj.Add(Chili);
        //Saver.instance.JsGameObj.Add(Bone2);
    }

    // Update is called once per frame
    void Update()
    {
 
        if (GameManager.instance.game_status == false) { return; }
        //if (CandyFallCount >= 10) { candyCountBool = false; return; }

        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            GiveMeCandy();
            Timer = 2f;

        }

    }
    public void AddBurgr()
    {
        Feed.Add(Burger);
        Feed.Add(Bone3);
    }

    //public void BuyBurger()
    //{
    //    //if (The_Score.instance.burgerCost < The_Score.instance.Candy_score) { return; }
    //    if (  ) { return; }
    //    Feed.Add(Burger);
    //    Feed.Add(Bone3);
    //    Saver.instance.JsGameObj.Add(Burger);
    //    Saver.instance.JsGameObj.Add(Bone3);

    //    The_Score.instance.Candy_score -= The_Score.instance.burgerCost;
    //    Saver.instance.jsonCandyScore -= The_Score.instance.burgerCost;

    //    Sc_Audio.instance.PlayBuyCandy();
    //    Saver.instance.Save();
    //}
    ////public void BuyBurger()
    ////{
    ////    if (The_Score.instance.burgerCost >= The_Score.instance.Candy_score)
    ////    {
    ////        Feed.Add(Burger);
    ////        Feed.Add(Bone3);

    ////        The_Score.instance.Candy_score -= The_Score.instance.burgerCost;

    ////        Sc_Audio.instance.PlayBuyCandy();

    ////    }
    ////    else if (The_Score.instance.burgerCost < The_Score.instance.Candy_score) { return; }
    ////}
    ///

    public void AddCandy()
    {
        Feed.Add(Candy);
        Feed.Add(Bone4);
    }
    //public void BuyCandy()
    //{
    //    if (The_Score.instance.candyCost < The_Score.instance.Candy_score) { return; }
    //    Feed.Add(Candy);
    //    Feed.Add(Bone4);
    //    //Saver.instance.JsGameObj.Add(Candy);
    //    //Saver.instance.JsGameObj.Add(Bone4);
    //    The_Score.instance.Candy_score -= The_Score.instance.candyCost;
    //    //Saver.instance.jsonCandyScore -= The_Score.instance.candyCost;
    //    Sc_Audio.instance.PlayBuyCandy();
    //    //Saver.instance.Save();
    //}

    public void AddCoocke()
    {
        Feed.Add(Coocke);
        Feed.Add(Bone5);
    }
    //public void BuyCoocke()
    //{
    //    if (The_Score.instance.coockyCost < The_Score.instance.Candy_score) { return; }
    //    Feed.Add(Coocke);
    //    Feed.Add(Bone5);
    //    //Saver.instance.JsGameObj.Add(Coocke);
    //    //Saver.instance.JsGameObj.Add(Bone5);
    //    The_Score.instance.Candy_score -= The_Score.instance.coockyCost;
    //    //Saver.instance.jsonCandyScore -= The_Score.instance.coockyCost;
    //    Sc_Audio.instance.PlayBuyCandy();
    //    //Saver.instance.Save();
    //}

    public void AddMeat()
    {
            Feed.Add(Meat);
            Feed.Add(Bone6);

    }
    //public void BuyMeat()
    //{
    //    if (The_Score.instance.meatCost < The_Score.instance.Candy_score) { return; }
    //    Feed.Add(Meat);
    //    Feed.Add(Bone6);
    //    //Saver.instance.JsGameObj.Add(Meat);
    //    //Saver.instance.JsGameObj.Add(Bone6);
    //    The_Score.instance.Candy_score -= The_Score.instance.meatCost;
    //    //Saver.instance.jsonCandyScore -= The_Score.instance.meatCost;
    //    Sc_Audio.instance.PlayBuyCandy();
    //    //Saver.instance.Save();
    //}
    ////public void BuyLife()
    ////{
    ////    if (The_Score.instance.lifeCost < The_Score.instance.Candy_score) { return; }
    ////    if (The_Score.instance.Lifes_score == 3) { return; }
    ////    if (The_Score.instance.Lifes_score == 2) { GameManager.instance.AAA_Lives.transform.GetChild(2).gameObject.SetActive(true); The_Score.instance.Candy_score -= The_Score.instance.lifeCost; Saver.instance.jsonCandyScore -= The_Score.instance.lifeCost; } //Saver.instance.Save();
    ////    if (The_Score.instance.Lifes_score == 1) { GameManager.instance.AAA_Lives.transform.GetChild(1).gameObject.SetActive(true); The_Score.instance.Candy_score -= The_Score.instance.lifeCost; Saver.instance.jsonCandyScore -= The_Score.instance.lifeCost;  }
    ////    if (The_Score.instance.Lifes_score == 0) { GameManager.instance.AAA_Lives.transform.GetChild(0).gameObject.SetActive(true); The_Score.instance.Candy_score -= The_Score.instance.lifeCost; Saver.instance.jsonCandyScore -= The_Score.instance.lifeCost;  }
    ////}
    //public void BuyLife()
    //{
    //    if (The_Score.instance.lifeCost < The_Score.instance.Candy_score) { return; }
    //    if (The_Score.instance.Lifes_score == 3) { return; }
    //    if (The_Score.instance.Lifes_score == 2) { GameManager.instance.AAA_Lives.transform.GetChild(2).gameObject.SetActive(true); The_Score.instance.Candy_score -= The_Score.instance.lifeCost;  } //Saver.instance.Save();Saver.instance.jsonCandyScore -= The_Score.instance.lifeCost;
    //    if (The_Score.instance.Lifes_score == 1) { GameManager.instance.AAA_Lives.transform.GetChild(1).gameObject.SetActive(true); The_Score.instance.Candy_score -= The_Score.instance.lifeCost;  }
    //    if (The_Score.instance.Lifes_score == 0) { GameManager.instance.AAA_Lives.transform.GetChild(0).gameObject.SetActive(true); The_Score.instance.Candy_score -= The_Score.instance.lifeCost;  }
    //}
}
