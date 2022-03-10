using UnityEngine;
using System.Collections;

public class CsRunner : HPbar
{
    public Vector2 jumpVelocity; //점프속도

    bool collision_box; //바닥과 충돌하고 있는 상태를 판별하기 위한 bool형 변수
                        //다중 점프를 불가능하게 하기위한 요소
                        //즉 바닥에서만 점프가 가능하게 하기위한 요소

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Gameover == true)
        {
            Debug.Log("GameOver");
        }

        else
        {
            //바닥면과 붙어있고, 스페이스키나 마우스 왼쪽버튼이 눌렸다면....
            if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && collision_box)
            {
                //jumpVelocity만큼 힘을 가해줍니다.
                //점프를 하게됩니다.
                transform.GetComponent<Rigidbody2D>().AddForce(jumpVelocity, ForceMode2D.Impulse);
            }
        }
    }

    //서로의 콜라이더가 처음 부딪혔을 때
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.transform.tag == "Ground")
        {
            collision_box = true; //바닥과 맞닿아 있음(점프 가능 상태)
        }
    }

    //서로의 콜라이더가 부딪힌 상태가 유지될 때때
    void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.transform.tag == "Ground")
        {
            collision_box = true; //바닥과 맞닿아 있음(점프 가능 상태)
        }
    }

    //서로의 콜라이더가 떨어질 때때
    void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.transform.tag == "Ground")
        {
            collision_box = false; //바닥과 맞닿아 있지 않음(점프 불가능 상태)
        }
    }
}