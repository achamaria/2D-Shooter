/*COMP3064 CRN13899 Assignment 1  
Akash Chamaria  - 101024951   
Friday, October 20, 2017                    
Instructor: Przemyslaw Pawluk*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//script to goto other screen
public class HomeScript : MonoBehaviour {

    public void LoadScene() {
        SceneManager.LoadScene("main"); //loading main scene
    }

}
