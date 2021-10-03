using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletBehaviour : MonoBehaviour
{
    private float speed = 5.0f;
    void Update()
    {
        transform.localScale = new Vector2(0.5f, 0.5f);
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

    }
}
