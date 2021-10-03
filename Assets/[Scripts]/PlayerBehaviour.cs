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
    }

    private IEnumerator Shoot()
    {
        isShooting = true;
        Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(fireRate);
        isShooting = false;
    }

}
