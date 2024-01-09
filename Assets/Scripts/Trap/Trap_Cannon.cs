using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_Cannon : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private float cooldownTimer;

    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject arrow;
    [SerializeField] public float direction;

    private void Start()
    {
        DetectDirection();
    }
    private void Attack()
    {
        cooldownTimer = 0;
        Instantiate(arrow, firePoint.position, Quaternion.Euler(new Vector3 (transform.position.x, transform.position.y, direction * (transform.position.z + 90))));
    }

    private void Update()
    {
        cooldownTimer += Time.deltaTime;
        if (cooldownTimer >= attackCooldown)
        {
            Attack();
        }
    }
    private void DetectDirection()
    {
        if (transform.rotation.z >= 0)
            direction = -1;
        if (transform.rotation.z <= 0)
            direction = 1;
    }
    
}
