using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator anim;

    [Header("Sound Manager")]
    [SerializeField] AudioClip jumpSound;
    [SerializeField] AudioClip deathSound;


    [Header ("Move Script")]
    [SerializeField] float speed = 10f;
    [SerializeField] float horizontalInput;
    [SerializeField] float jumpForce = 5f;

    [Header("Status")]
    [SerializeField] bool isGrounded;
    [SerializeField] bool isDead;
    [SerializeField] private bool isMoving = false;
    public Action onDead;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        if (!isDead)
        {
            Move();
            Jump();
            Flip();
        }
        AnimatorController();
    }
    private void AnimatorController()
    {
        anim.SetBool("isGrounded", isGrounded);
        anim.SetFloat("yVelocity", rb.velocity.y);
        anim.SetBool("isMoving", isMoving);
        anim.SetBool("isDead", isDead);
    }

    private void Flip()
    {
        if (horizontalInput > 0.01f)
        {
            transform.localScale = Vector3.one;
        }

        if (horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3 (-1,1,1);
        }
    }

    private void Move()
    {
        if (horizontalInput != 0)
        {
            rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);
            isMoving = true;
        }
        if (horizontalInput == 0)
            isMoving = false;
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            AudioManager.Instance.PlaySFX("Jump");
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("foreground"))
        {
            isGrounded = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            AudioManager.Instance.PlaySFX("GameOver");
            isDead = true;
            onDead?.Invoke();
        }
    }
}
