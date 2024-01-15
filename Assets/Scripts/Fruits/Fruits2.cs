using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits2 : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private Animator anim;
    [SerializeField] private bool collected = false;
    [SerializeField] protected int _score;

    [Header("Sound Manager")]
    [SerializeField] AudioClip pickupSound;

    private void Start()
    {
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        AnimatorController();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            AudioManager.instance.PlaySFX("Collect");
            ScoreManager.instance.AddPoint(_score);
            FruitDestroy();
        }
    }

    protected void FruitDestroy()
    {
        collected = true;
        boxCollider.enabled = !boxCollider.enabled;
        Destroy(gameObject, 1);
    } 

    private void AnimatorController()
    {
        anim.SetBool("collected", collected);
    }
}
