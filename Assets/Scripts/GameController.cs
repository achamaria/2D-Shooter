using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    //public variables
    [SerializeField]
    GameObject enemy1;
    [SerializeField]
    GameObject enemy2;
    [SerializeField]
    GameObject playerTop;
    [SerializeField]
    GameObject playerBottom;
    [SerializeField]
    Text lifeLabel;
    [SerializeField]
    Text scoreLabel;
    [SerializeField]
    Text gameOverLabel;
    [SerializeField]
    Text highScoreLabel;
    [SerializeField]
    Button resetBtn;

    // initializing main scene elements
    private void initialize()
    {

        Player.Instance.Score = 0;
        Player.Instance.Life = 5;

        gameOverLabel.gameObject.SetActive(false);
        highScoreLabel.gameObject.SetActive(false);
        resetBtn.gameObject.SetActive(false);

        lifeLabel.gameObject.SetActive(true);
        scoreLabel.gameObject.SetActive(true);

        StartCoroutine("AddEnemy");
    }

    // setting up scene when game is over
    public void gameOver()
    {
        Player.Instance.HighScore = Player.Instance.Score;
        gameOverLabel.gameObject.SetActive(true);
        highScoreLabel.gameObject.SetActive(true);
        resetBtn.gameObject.SetActive(true);

        lifeLabel.gameObject.SetActive(false);
        scoreLabel.gameObject.SetActive(false);
    }

    //updaing ui elements
    public void updateUI()
    {
        scoreLabel.text = "Score: " + Player.Instance.Score;
        lifeLabel.text = "Life: " + Player.Instance.Life;
        highScoreLabel.text = "High Score: " + Player.Instance.HighScore;
    }

    // Use this for initialization
    void Start()
    {
        Player.Instance.gameCtrl = this;
        initialize();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //function to reset or reload the main scene
    public void ResetBtnClick()
    {
        SceneManager.LoadScene("main");
    }

    //recursion function to add enemies
    private IEnumerator AddEnemy()
    {

        int time = Random.Range(10, 15);
        yield return new WaitForSeconds((float)time);
        Instantiate(enemy1);
        Instantiate(enemy2);
        StartCoroutine("AddEnemy");
    }


}
