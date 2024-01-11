using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits2 : MonoBehaviour
{
    [SerializeField] private float lifeTime;
    [SerializeField] private float countLifeTime;

    private Animator anim;
    [SerializeField] private bool collected = false;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        countLifeTime += Time.deltaTime;
        if (countLifeTime >= lifeTime)
        {
            collected = true;
            Destroy(gameObject);
        }
        AnimatorController();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            ScoreManager.instance.AddPointCherry();
            collected = true;
            Destroy(gameObject);
        }
    }

    private void AnimatorController()
    {
        anim.SetBool("collected", collected);
    }





}
