using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsGround : MonoBehaviour
{
    public float speed; // 이동 속도

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // 왼쪽 방향으로 speed만큼 이동
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // x 좌표가 -12.8보다 작아지게 되는 경우
        if (transform.position.x < -12.8f)
        {
            // 위치를 0, 0 으로 옮긴다
            transform.position = new Vector2(0, 0);
        }
    }
}