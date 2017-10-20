using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
    //public variables
    [SerializeField]
    float xSpeed = 1f;
    [SerializeField]
    float yPos;

    private Transform _transform;
    private Vector2 _currentSpeed;
    private Vector2 _currentPosition;

    // Use this for initialization
    void Start()
    {
        _transform = gameObject.GetComponent<Transform>(); //getting the object
        Reset();// resetting the object
    }
    // resetting the object
    public void Reset()
    {
        _currentSpeed = new Vector2(xSpeed, 0);
    }
    
    // Update is called once per frame
    void Update()
    {
        _currentPosition = _transform.position;
        _currentPosition += _currentSpeed;
        _transform.position = _currentPosition;

        if (_currentPosition.x >= 92)
        {
            Destroy(gameObject);
        }
    }

    public void DestroyMe()
    {
        Destroy(gameObject);
    }
}
