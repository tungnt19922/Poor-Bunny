using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpawn : MonoBehaviour
{
    [SerializeField] GameObject Saw;
    [SerializeField] GameObject CannonLeft;
    [SerializeField] GameObject CannonRight;
    [SerializeField] GameObject Kunai;
    [SerializeField] GameObject Circle;


    private void Start()
    {
        Saw.SetActive(false);
        CannonLeft.SetActive(false);
        CannonRight.SetActive(false);
        Kunai.SetActive(false);
        Circle.SetActive(false);
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(5);
        Saw.SetActive(true);
        yield return new WaitForSeconds(5);
        CannonLeft.SetActive(true);
        yield return new WaitForSeconds(5);
        CannonRight.SetActive(true);
        yield return new WaitForSeconds(5);
        Kunai.SetActive(true);
        yield return new WaitForSeconds(5);
        Circle.SetActive(true);
    }




}
