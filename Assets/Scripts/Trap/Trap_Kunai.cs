using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_Kunai : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2D;
    [SerializeField] float speed;
    [SerializeField] Vector3 lastVelocity;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.velocity = ((transform.up + transform.right) * speed);
    }
    private void Update()
    {
        lastVelocity = rb2D.velocity;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);
        rb2D.velocity = direction * speed;
    }
}
