using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_Arrow : MonoBehaviour
{
    public GameObject arrowPrefab;
    public float spawnInterval = 3f;
    public float startDelay = 10f;

    void Start()
    {
        // Bắt đầu gọi hàm SpawnRandomArrow lặp lại sau mỗi 3 giây, bắt đầu từ giây thứ 10
        InvokeRepeating("SpawnRandomArrow", startDelay, spawnInterval);
    }

    void SpawnRandomArrow()
    {
        // Tạo một vị trí ngẫu nhiên trong khoảng từ (-5,5) đến (5,5)
        Vector2 randomPosition = new Vector2(Random.Range(-5f, 5f),5f);

        // Tạo mũi tên tại vị trí ngẫu nhiên
        Instantiate(arrowPrefab, randomPosition, Quaternion.identity);
    }
}
