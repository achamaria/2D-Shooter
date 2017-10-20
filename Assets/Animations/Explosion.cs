/*COMP3064 CRN13899 Assignment 1  
Akash Chamaria  - 101024951   
Friday, October 20, 2017                    
Instructor: Przemyslaw Pawluk*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        yield return new WaitForSeconds(0.3f);    //Wait one frame

        DestroyMe();
    }


    public void DestroyMe()
    {
        Destroy(gameObject);
    }

   

}
