using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cherry : Fruits2
{
    [SerializeField] private float lifeTime;
    [SerializeField] private float countLifeTime = 0;


    private void Update()
    {
        AutoDestroyFruits();
    }
    private void AutoDestroyFruits()
    {
        countLifeTime += Time.deltaTime;
        if (countLifeTime >= lifeTime)
            FruitDestroy();
    }
}
