using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits2 : MonoBehaviour
{
    [SerializeField] private float lifeTime;
    [SerializeField] private float countLifeTime;
    [SerializeField] private BoxCollider2D boxCollider;

    private Animator anim;
    [SerializeField] private bool collected = false;

    private void Start()
    {
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        AutoDestroyFruits();
        AnimatorController();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            ScoreManager.instance.AddPointCherry();
            FruitDestroy();
        }
    }

    private void AutoDestroyFruits()
    {
        countLifeTime += Time.deltaTime;
        if (countLifeTime >= lifeTime)
            FruitDestroy();
    }
    private void FruitDestroy()
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
