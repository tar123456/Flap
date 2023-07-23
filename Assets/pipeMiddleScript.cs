using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class pipeMiddleScript : MonoBehaviour
{

    // Start is called before the first frame update
    public LogicScript logic;
    public int scoreIncrement;
    public AudioClip pointClip;
    
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
        AudioSource source = GetComponent<AudioSource>();
        
        if (collision.gameObject.layer == 3) //birdie layer
        {
            source.clip = pointClip;
            source.Play();
            logic.addScore(scoreIncrement);
            
            Debug.Log("Triggered");
        }
    }
}
