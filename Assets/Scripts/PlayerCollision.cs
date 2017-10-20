using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    //public variables
    [SerializeField]
    GameController gameController;

    [SerializeField]
    GameObject explosion;


    private AudioSource _explosionSound;

    // Use this for initialization
    void Start()
    {
        _explosionSound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //function to define collision
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("enemy")) //if collided element is with the tag "enemy"
        {
            Debug.Log("Collision enemy\n");
            //instantiating explosion
            Instantiate(explosion)
                .GetComponent<Transform>()
                .position = other.gameObject
                    .GetComponent<Transform>()
                    .position;

            //resetting the position of enemy
            other.gameObject.
                GetComponent<EnemyController>()
                .Reset();
           Player.Instance.Life -= 1;
        }

    }

}
