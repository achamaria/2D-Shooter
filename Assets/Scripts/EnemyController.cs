﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    //public variables
    [SerializeField]
    float xSpeed = 2f;
    [SerializeField]
    float yPos;

    [SerializeField]
    GameObject explosion;

    private Transform _transform;
    private Vector2 _currentSpeed;
    private Vector2 _currentPosition;

    // Use this for initialization
    void Start()
    {
        _transform = gameObject.GetComponent<Transform>(); //getting the object
        Reset(); // resetting the object
    }

    // resetting the object
    public void Reset()
    {
        _currentSpeed = new Vector2(xSpeed, 0);
        _transform.position = new Vector2(82, yPos);
    }


    // Update is called once per frame
    void Update()
    {
        _currentPosition = _transform.position;
        _currentPosition -= _currentSpeed;
        _transform.position = _currentPosition;

        if (_currentPosition.x <= -74)
        {
            Reset();
        }
    }

    //detecting and defining collision of enemy and player
    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag.Equals("bullet"))
        {
            Debug.Log("Collision bullet\n");

            Instantiate(explosion)
                .GetComponent<Transform>()
                .position = other.gameObject
                    .GetComponent<Transform>()
                    .position;
            this.gameObject.
                GetComponent<EnemyController>()
                .Reset();

            other.gameObject.
                GetComponent<BulletController>()
                .DestroyMe();

            Player.Instance.Score += 100;

        }

    }
}