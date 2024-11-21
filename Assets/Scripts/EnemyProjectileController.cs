using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectileController : MonoBehaviour
{
    public int pointValue;
    public GameManager gm;

    //Splitting Variables
    public GameObject smallerEnemyProjectile;
    public int smallerEnemyProjectilesToSpawn;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Projectile"))
        {
            gm.AddScore(pointValue);
            Destroy(collision.gameObject);
            SpawnSmaller(smallerEnemyProjectilesToSpawn);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }

    private void SpawnSmaller(int numberToSpawn)
    {
        if(smallerEnemyProjectile != null)
        {
            for(int i = 0; i < numberToSpawn; i++)
            Instantiate(smallerEnemyProjectile, transform.position, transform.rotation);
        }
    }
}
