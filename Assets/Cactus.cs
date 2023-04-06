using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour
{
    public float speedX;
    public Score scoreScipt;
    private bool pointsCounted = false;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 currPosi = transform.position;
        currPosi.x -= speedX * Time.deltaTime;
        transform.position = currPosi;

        if (transform.position.x < -11.0f)
        {
            transform.position = new Vector3(11.0f, Random.Range(-3.3f, 3.3f), 0.0f);
            pointsCounted = false;
        }
        if (transform.position.x < -5.0f && !pointsCounted)
        {
            scoreScipt.ScoreUp();
            pointsCounted = true;
        }

    }
    

}
