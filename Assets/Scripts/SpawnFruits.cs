using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruits : MonoBehaviour
{
    [SerializeField] private GameObject apple;
    [SerializeField] private GameObject cherry;

    [SerializeField] private float appleSpawnCooldown;
    [SerializeField] private float appleCooldownTimer;

    [SerializeField] private float cherrySpawnCooldown;
    [SerializeField] private float cherryCooldownTimer;

    private void Update()
    {
        appleCooldownTimer += Time.deltaTime;
        if (appleCooldownTimer >= appleSpawnCooldown)
        {
            SpawnApple();
        }
        cherryCooldownTimer += Time.deltaTime;
        if (cherryCooldownTimer >= cherrySpawnCooldown)
        {
            SpawnCherry();
        }
    }

    private void SpawnCherry()
    {
        cherryCooldownTimer = 0;
        if (cherry != null)
            Instantiate(cherry, new Vector2(Random.Range(-6, 6), Random.Range(-2, 4)), Quaternion.identity);
    }

    private void SpawnApple()
    {
        appleCooldownTimer = 0;
        if (apple != null)
            Instantiate(apple, new Vector2 (Random.Range(-6,6), Random.Range(-2,4)), Quaternion.identity);
    }
}

