using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_Arrow : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float firstSpeed = 1;
    [SerializeField] private float secondSpeed = 2;
    [SerializeField] private float waitTime = 2;

    void Start()
    {

    }
    private void Update()
    {
        transform.position = transform.position + new Vector3(0, -speed * Time.deltaTime, 0);
        StartCoroutine(UpdateSpeed());
    }
    private IEnumerator UpdateSpeed()
    {
        speed = firstSpeed;
        yield return new WaitForSeconds(waitTime);
        speed = secondSpeed;
    }
}
