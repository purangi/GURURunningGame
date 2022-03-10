using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staminaItem : MonoBehaviour
{
    public float speed = 0.015f;        //장애물 이동 속도

    private Vector3 firstPos = new Vector3(14.0f, 5.8f, 0f);        //처음 위치
    private Vector3 endPos = new Vector3(-14.0f, 5.8f, 0f);       //도착 위치
    
    void Update()
    {
        //도착 위치로 장애물 이동
        transform.position = Vector3.MoveTowards(transform.position, endPos, speed);

        //만약 도착했다면 처음 위치로 이동
        if (transform.position.x <= -14)
        {
            transform.position = firstPos;
        } 
    }
}
