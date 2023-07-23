using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    float timer = 0;
    public float heightOffset = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnPipes();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }

        else
        {
            spawnPipes();
            timer = 0;
        }

    }


    void spawnPipes()
    {
        var lowpoint = transform.position.y - heightOffset;
        var highpoint = transform.position.y + heightOffset;
        var position = new Vector3(transform.position.x, Random.Range(lowpoint, highpoint), transform.position.z);
        Instantiate(pipe, position, transform.rotation);
    }
}
