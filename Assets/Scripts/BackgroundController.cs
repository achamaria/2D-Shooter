﻿/*COMP3064 CRN13899 Assignment 1  
Akash Chamaria  - 101024951   
Friday, October 20, 2017                    
Instructor: Przemyslaw Pawluk*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour {

    //Public variables
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float startX;
    [SerializeField]
    private float endX;

    //private variables
    private Transform _transform;
    private Vector2 _currentPos;

    // Use this for initialization
    void Start()
    {
        _transform = gameObject.GetComponent<Transform>();
        _currentPos = _transform.position;
        Reset();
    }

    // Update is called once per frame
    void Update()
    {
        _currentPos = _transform.position;
        //move background right to left
        _currentPos -= new Vector2(speed, 0);

        //check if we need to reset
        if (_currentPos.x < endX)
        {
            //reset
            Reset();
        }
        //apply changes
        _transform.position = _currentPos;

    }

    //function to reset background
    private void Reset()
    {
        _currentPos = new Vector2(startX, 0);
    }
}
