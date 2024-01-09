using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruits : MonoBehaviour
{
    [SerializeField] private GameObject apple;

    [SerializeField] private float appleSpawnCooldown;
    [SerializeField] private float appleCooldownTimer;


    private void Update()
    {
        appleCooldownTimer += Time.deltaTime;
        if (appleCooldownTimer >= appleSpawnCooldown)
        {
            SpawnApple();
        }
    }

    private void SpawnApple()
    {
        appleCooldownTimer = 0;
        if (apple != null)
            Instantiate(apple, new Vector2 (Random.Range(-6,6), Random.Range(-2,4)), Quaternion.identity);
    }

}

