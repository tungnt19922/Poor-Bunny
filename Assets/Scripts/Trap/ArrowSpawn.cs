using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawn : MonoBehaviour
{
    [SerializeField] GameObject arrowTrap;
    [SerializeField] float spawnTime = 5f;
    [SerializeField] float leftSpawnPoint;
    [SerializeField] float rightSpawnPoint;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnArrow());
    }

    IEnumerator SpawnArrow()
    {
        while (true)
        {
            var wanted = UnityEngine.Random.Range(leftSpawnPoint, rightSpawnPoint);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(arrowTrap, position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
            Destroy(gameObject, 5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
