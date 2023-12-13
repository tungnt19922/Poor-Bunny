using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_Saw : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private Animator animator;
    public Transform[] points; // Các điểm A, B, C, D
    public float speed = 5f; // Tốc độ di chuyển
    private int currentPointIndex = 0; // Index của điểm hiện tại
    private int direction = 1; // Hướng di chuyển: 1 là chuyển từ điểm A đến D, -1 là chuyển từ D về A
    private int sequenceStep = 0; // Bước trong chuỗi di chuyển


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        MoveObject();
    }

    void MoveObject()
    {
        // Kiểm tra xem đã đến điểm đích chưa
        if (Vector2.Distance(transform.position, points[currentPointIndex].position) < 0.1f)
        {
            // Chuyển sang điểm tiếp theo hoặc trước đó tùy theo hướng
            currentPointIndex += direction;

            // Cập nhật bước trong chuỗi di chuyển
            sequenceStep = (sequenceStep + direction + points.Length) % points.Length;

            // Nếu đến điểm cuối cùng, thay đổi hướng
            if (currentPointIndex == points.Length - 1 || currentPointIndex == 0)
            {
                direction *= -1;
            }
        }

        // Di chuyển vật thể đến điểm đích
        transform.position = Vector2.MoveTowards(transform.position, points[currentPointIndex].position, speed * Time.deltaTime);
    }

}
