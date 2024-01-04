using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap_Arrow_Cannon : MonoBehaviour
{
    [SerializeField] private float speed;
    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("foreground"))
        {
            Destroy(gameObject);
        }
    }
}
