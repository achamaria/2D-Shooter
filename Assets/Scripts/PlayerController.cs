/*COMP3064 CRN13899 Assignment 1  
Akash Chamaria  - 101024951   
Friday, October 20, 2017                    
Instructor: Przemyslaw Pawluk*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //public variables
    public int _highScore;
    
    [SerializeField]
    private float speed = 7f;
    [SerializeField]
    private float leftX;
    [SerializeField]
    private float rightX;

    [SerializeField]
    private float maxY;
    [SerializeField]
    private float minY;

    [SerializeField]
    GameObject shot;
    [SerializeField]
    GameObject bullet;

    //variable to get position of player
    Vector2 originalPosition;

    private Transform _transform;
    private Vector2 _currentPos;


    // for initialization
    void Start()
    {
        originalPosition = gameObject.transform.position;
        _transform = gameObject.GetComponent<Transform>();
        _currentPos = _transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        _currentPos = _transform.position;

        float userInput = Input.GetAxis("Horizontal"); //getting user input for x axis movement
        float userInputY = Input.GetAxis("Vertical");  //getting user input for y axis movement
        
        // if user input is negative x asix
        if (userInput < 0)
        {
            _currentPos -= new Vector2(speed, 0); //moving player left
        }

        // if user input is positive x asix
        if (userInput > 0)
        {
            _currentPos += new Vector2(speed, 0); //moving player right
        }

        // if user input is negative y asix
        if (userInputY < 0)
        {
            _currentPos -= new Vector2(0, speed); //moving player down
        }

        // if user input is positive y asix
        if (userInputY > 0)
        {
            _currentPos += new Vector2(0, speed); //moving player up
        }

        // checking user input for bullets
        if (Input.GetKeyDown(KeyCode.Space)) { //if user press space
            //instantiating bullet
            Instantiate(shot)                  
                .GetComponent<Transform>()
                .position = new Vector2(_currentPos.x+30,_currentPos.y-4);
            Instantiate(bullet)
                .GetComponent<Transform>()
                .position = new Vector2(_currentPos.x + 30, _currentPos.y - 4);
            Delay(2f);
        }

            CheckBounds(); //function to check the player boundry of the screen
        _transform.position = _currentPos;
    }

    IEnumerator Delay(float delay)
    {
        yield return new WaitForSeconds(delay);
    }


    //reset player position
    public void Reset()
    {
        gameObject.transform.position = originalPosition;
    }

    //function to check the player boundry of the screen
    private void CheckBounds()
    {

        if (_currentPos.x < leftX)
        {
            _currentPos.x = leftX;
        }

        if (_currentPos.x > rightX)
        {
            _currentPos.x = rightX;
        }

        if (_currentPos.y < maxY)
        {
            _currentPos.y = maxY;
        }

        if (_currentPos.y > minY)
        {
            _currentPos.y = minY;
        }

    }
}
