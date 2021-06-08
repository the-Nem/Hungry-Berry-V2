using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_Audio : MonoBehaviour
{
    public static Sc_Audio instance;
    private void Awake()
    {
        if (instance == null) { instance = this; }
    }

    public AudioSource BuyCandy;
    public AudioSource DogFart;
    public AudioSource Eating;
    public AudioSource EatPepper;
    public AudioSource GameOver;
    public AudioSource Win;

    [HideInInspector]
    public int FartCount;
    [HideInInspector]
    public int CaloryCount;

    void Update()
    {
        if (FartCount == 10) { PlayDogFart(); FartCount = 0; }
        if (CaloryCount == 3) { PlayDogFart(); CaloryCount = 0; }
    }



    public void PlayBuyCandy() { BuyCandy.Play(); 
    }             
    public void PlayDogFart() { DogFart.Play(); 
    }
    public void PlayEating() {Eating.Play(); 
    }
    public void PlayEatPepper() { EatPepper.Play(); 
    }
    public void PlayGameOver() { GameOver.Play(); 
    }
    public void PlayWin() { Win.Play();
    }


    
}
