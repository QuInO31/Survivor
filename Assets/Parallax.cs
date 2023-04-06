using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float speedX;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currPosi = transform.position;
        currPosi.x -= speedX * Time.deltaTime;
        transform.position = currPosi;

        if (transform.position.x < -20.0f)
        {
            transform.position += new Vector3(40.0f, 0.0f, 0.0f);
        }
    }
}
