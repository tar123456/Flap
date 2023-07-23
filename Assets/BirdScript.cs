using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    //Objects and Variables

    public Rigidbody2D rigidbody2D;
    public float flapStrength = 1.0f;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public float upperlimit = 20;
    public float lowerLimit = -20;
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& birdIsAlive)
        {
            rigidbody2D.velocity = Vector2.up * flapStrength;
        }

        if (transform.position.y > upperlimit || transform.position.y < lowerLimit)
        {
            logic.gameOver();
            birdIsAlive = false;
        }

       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
