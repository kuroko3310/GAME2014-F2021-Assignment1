/* 
GAME2014-F2021-Assignment1 by Jen Marc Capistrano
Student #: 101218004
Last Modified: 3 October 2021
Course: GAME2014-F2021-Tom Tsiliopoulos

Program Description:
This is a clone or-so of Space Invaders made for mobile

Script Description:
This is for the player's bullet behaviour

Code Source: Invaders from OuterSpace by Comp-3 Interactive
https://www.youtube.com/watch?v=JfICj5yp44k&list=PLfhbBaEcybmhGhADxKSqqliuCLg3xY_ep
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletBehaviour : MonoBehaviour
{
    private float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector2(0.5f, 0.5f);
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        
    }
}
