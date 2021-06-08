using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//this is about candys relationship with others
public class Sc_collider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (this.gameObject.tag == "Pepper") 
            {
                Destroy(gameObject);
                The_Score.instance.LooseLive(-1);
               // XXXX.instance.quantityEatedCandys++;
                XXXX.instance.AffectToEatedCandys(1);

                Sc_Audio.instance.PlayEatPepper();
                //add particle sys

            }

            else
            {

                Destroy(gameObject);
                The_Score.instance.CandyCalculation(1);
                //XXXX.instance.quantityEatedCandys++;
                XXXX.instance.AffectToEatedCandys(1);


                Sc_Audio.instance.FartCount++;
                Sc_Audio.instance.CaloryCount++;
                //add particle sys
            }


        }
        else if (collision.gameObject.tag == "Black_hole")
        {
            //Saver.instance.Save();
            
            
            Destroy(gameObject);

            //XXXX.instance.quantityDestroedCandys++;
            XXXX.instance.AffectToDestroedCandys(1);
            //add sound
            //add particle sys

        }
       // else if(collision.gameObject.tag== "Black_Hole2") { Destroy(gameObject); }
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

}
