using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienBehaviour : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject mothershipPrefab;

    private Vector3 hMoveDistance = new Vector3(0.05f, 0, 0);
    private Vector3 vMoveDistance = new Vector3(0, 0.1f, 0);
    private Vector3 mothershipSpawnPos = new Vector3(2.5f, 2.5f, 0);

    private const float MAX_LEFT = -1.9f;
    private const float MAX_RIGHT = 1.9f;
    private const float MAX_MOVE_SPEED = 0.02f;

    private float moveSpeed = 0.01f;
    private const float moveRate = 0.005f;


    private float shootSpeed = 3f;
    private const float shootRate = 3f;

    private float mothershipTimer = 1f;
    private const float MOTHERSHIP_MIN = 15f;
    private const float MOTHERSHIP_MAX = 60f;

    private bool isMovingRight;
    public static List<GameObject> allAliens = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("Alien"))
            allAliens.Add(go);
    }

    // Update is called once per frame
    void Update()
    {
        if (moveSpeed <= 0)
            MoveEnemies();
        if (shootSpeed <= 0)
            Shoot();
        if (mothershipTimer <= 0)
            SpawnMothership();

        moveSpeed -= Time.deltaTime;
        shootSpeed -= Time.deltaTime;
        mothershipTimer -= Time.deltaTime;
    }

    private void MoveEnemies()
    {
        if(allAliens.Count > 0)
        {
            int hitMax = 0;
            for (int i = 0; i < allAliens.Count; i++)
            {
                if (isMovingRight)
                    allAliens[i].transform.position += hMoveDistance;
                else
                    allAliens[i].transform.position -= hMoveDistance;
                if (allAliens[i].transform.position.x > MAX_RIGHT || allAliens[i].transform.position.x < MAX_LEFT)
                    hitMax++;
            }
            
            if (hitMax > 0)
            {
                for (int i = 0; i < allAliens.Count; i++)
                {
                    allAliens[i].transform.position -= vMoveDistance;
                }
                isMovingRight = !isMovingRight;
            }

            moveSpeed = GetMoveSpeed();
        }
        
    }

    private void Shoot()
    {
        Vector2 pos = allAliens[Random.Range(0, allAliens.Count)].transform.position;

        Instantiate(bulletPrefab, pos, Quaternion.identity);

        shootSpeed = shootRate;
    }

    public void SpawnMothership()
    {
        mothershipPrefab.transform.localScale = new Vector3(0.5f, 0.5f, 0f);
        Instantiate(mothershipPrefab, mothershipSpawnPos, Quaternion.identity);
        mothershipTimer = Random.Range(MOTHERSHIP_MIN, MOTHERSHIP_MAX);

    }

    private float GetMoveSpeed()
    {
        float f = allAliens.Count * moveRate;

        if (f < MAX_MOVE_SPEED)
            return MAX_MOVE_SPEED;
        else
            return f;
       
    }
}
