using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CsItemCreater : MonoBehaviour
{
    //프리팹을 넣어줄 공개변수들
    public Transform HpItem;

    float timer = 0; //누적시간을 저장할 변수

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //시간을 누적시킴
        timer += Time.deltaTime;

        //2초가 지나면...
        if (timer > 7.23f)
        {
            //적 생성
            CreateHpItem();

            //누적시간 초기화
            timer = 0;
        }
    }

    /// 적 생성 ///
    void CreateHpItem()
    {
        //랜덤하게 생성하기위해 랜덤값을 받습니다.
        int ItemNum = Random.Range(1, 3);

        //랜덤값에 따라 다른 적을 생성합니다.
        switch (ItemNum)
        {
            case 1:
                Instantiate(HpItem, transform.position, Quaternion.identity);
                break;
            case 2:
                break;
        }
    }

}
