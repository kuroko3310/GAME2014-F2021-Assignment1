/* 
GAME2014-F2021-Assignment1 by Jen Marc Capistrano
Student #: 101218004
Last Modified: 3 October 2021
Course: GAME2014-F2021-Tom Tsiliopoulos

Program Description:
This is a clone or-so of Space Invaders made for mobile

Script Description:
This is for the player controller such as movement and fire

Code Source: Invaders from OuterSpace by Comp-3 Interactive
https://www.youtube.com/watch?v=JfICj5yp44k&list=PLfhbBaEcybmhGhADxKSqqliuCLg3xY_ep
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public GameObject bulletPrefab;

    private const float MAX_LEFT = -2.0f;
    private const float MAX_RIGHT = 2.0f;

    private float speed = 3.0f;
    private bool isShooting;
    private float fireRate = 0.5f;
    private bool isMovingLeft;
    private bool isMovingRight;

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        if (Input.GetKey(KeyCode.A) && transform.position.x > MAX_LEFT)
            transform.Translate(Vector2.left * Time.deltaTime * speed);

        if (Input.GetKey(KeyCode.D) && transform.position.x < MAX_RIGHT)
            transform.Translate(Vector2.right * Time.deltaTime * speed);

        if (Input.GetKey(KeyCode.Space) && !isShooting)
            StartCoroutine(Shoot());
#endif
        if(isMovingLeft && transform.position.x > MAX_LEFT)
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        if (isMovingRight && transform.position.x < MAX_RIGHT)
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        if (Input.GetKey("escape"))
            Application.Quit();
    }

    private IEnumerator Shoot()
    {
        isShooting = true;
        Vector3 BulletSpawnPos = new Vector3(transform.position.x + 0.05f, transform.position.y + 0.25f, transform.position.z);
        Instantiate(bulletPrefab, BulletSpawnPos, Quaternion.identity);
        yield return new WaitForSeconds(fireRate);
        isShooting = false;
    }

    public void LeftButtonDown()
    {
        isMovingLeft = true;
    }

    public void RightButtonDown()
    {
        isMovingRight = true;
    }

    public void DirectionReleased()
    {
        isMovingLeft = false;
        isMovingRight = false;
    }

    public void ShootButton()
    {
        if (!isShooting)
            StartCoroutine(Shoot());
    }
}
