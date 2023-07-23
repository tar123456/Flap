using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class pipeMiddleScript : MonoBehaviour
{

    // Start is called before the first frame update
    public LogicScript logic;
    public int scoreIncrement;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3) //birdie layer
        {
            logic.addScore(scoreIncrement);
            Debug.Log("Triggered");
        }
    }
}
