using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player{

    //public variable
    public GameController gameCtrl;

    //private variables
    private int _score = 0;
    private int _life = 5;
    private int _highScore = 0;

    //constructor
    private Player()
    {

    }

    private static Player _instance; //declaring player instance

    //getter of player instance
    public static Player Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Player();
            }
            return _instance;
        }
    }

    //getter setter for score
    public int Score
    {
        get { return _score; }
        set
        {
            _score = value;
            gameCtrl.updateUI();
        }

    }
    //getter setter for highscore
    public int HighScore
    {
        get { return _highScore; }
        set
        {
            _score = value;
            this._highScore = this._score;
            gameCtrl.updateUI();
        }

    }

    //getter setter for life
    public int Life
    {
        get { return _life; }
        set
        {
            _life = value;


            if (_life <= 0)
            {
                //game over
                this._highScore = this._score;
            
                 gameCtrl.gameOver();
            }
            else
            {
                //lifeLabel.text = "Life: " + _life;
                gameCtrl.updateUI();
            }
        }
    }
}
