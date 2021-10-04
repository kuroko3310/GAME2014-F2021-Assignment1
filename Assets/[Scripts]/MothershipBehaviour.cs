/* 
GAME2014-F2021-Assignment1 by Jen Marc Capistrano
Student #: 101218004
Last Modified: 3 October 2021
Course: GAME2014-F2021-Tom Tsiliopoulos

Program Description:
This is a clone or-so of Space Invaders made for mobile

Script Description:
A script for a unique enemy, mothership or UFO that pass across the screen every half a minute or so

Code Source: Invaders from OuterSpace by Comp-3 Interactive
https://www.youtube.com/watch?v=JfICj5yp44k&list=PLfhbBaEcybmhGhADxKSqqliuCLg3xY_ep
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MothershipBehaviour : MonoBehaviour
{
    public int scoreValue;

    private const float MAX_LEFT = -4f;
    private float speed = 3;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
        if (this != null)
        {
            if (transform.position.x <= MAX_LEFT)
                Destroy(gameObject);
        }
       
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        
    }
}
