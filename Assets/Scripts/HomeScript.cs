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
