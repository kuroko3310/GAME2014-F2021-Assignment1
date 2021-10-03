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

        if (transform.position.x <= MAX_LEFT)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        
    }
}
