using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsItem : MonoBehaviour
{
    public AudioClip sndEffect;
    public float speed; //이동 속도

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //왼쪽 방향으로 speed만큼 움직여 줍니다.
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // x 좌표가 -8 보다 작으면 해당 오브젝트를 삭제합니다.
        if (transform.position.x < -8)
        {
            //해당 오브젝트를 지워줌.
            Destroy(gameObject);
        }

    }

    //IsTrigger를 체크했을 때 발생하는 콜백수함
    void OnTriggerEnter2D(Collider2D coll)
    {
        //충돌한 오브젝트의 이름이 runner일 경우
        //Tag를 사용하지 않고 name을 사용하는 방식
        if (coll.transform.name == "runner")
        {
            Debug.Log("runner collider");
            HPbar.isTrigger2 = true;
            AudioSource.PlayClipAtPoint(sndEffect, transform.position);
            Destroy(gameObject);
        }
    }
}
