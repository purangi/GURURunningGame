using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class CsEnemyCreater : HPbar
{ //프리팹을 넣어줄 공개변수들
    public Transform Cactus1;
    public Transform Cactus2;

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
        if(Gameover == true)
        {

        }

        else
        {
            //2초가 지나면...
            if (timer > 3.0f)
            {
                //적 생성
                CreateEnemy();

                //누적시간 초기화
                timer = 0;
            }
        }
    }

    /// 적 생성 ///
    void CreateEnemy()
    {
        //랜덤하게 생성하기위해 랜덤값을 받습니다.
        int cactusNum = Random.Range(1, 3);

        //랜덤값에 따라 다른 적을 생성합니다.
        switch (cactusNum)
        {
            case 1:
                Instantiate(Cactus1, transform.position, Quaternion.identity);
                break;
            case 2:
                Instantiate(Cactus2, transform.position, Quaternion.identity);
                break;
        }
    }

}
