using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPbar : MonoBehaviour
{
    //[SerializeField]
    private Slider hpbar; //slider의 max값은 1임

    private float maxHP = 100;
    private float curHP = 100;

    public static bool isTrigger; //장애물과 runner가 부딪혔는지 확인하는 변수
    public static bool isTrigger2; // 장애물과 item(힐템)이 부딪혔는지 확인하는 변수 

    public static bool Gameover; // 게임오버시 scene전환을 위해 필요한 bool변수

    private const float coef = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        hpbar = GetComponent<Slider>();//이 스크립트가 붙은 Slider를 가져와서 hpbar에 가져온다.
        hpbar.value = (float)curHP / (float)maxHP;   //현재체력을 1로초기화(slider의 max값이 1이므로)
    }




    // Update is called once per frame
    void Update()
    {
        //일정시간으로 감소

        //hpbar.value -= Time.deltaTime;
        hpbar.value -= coef * Time.deltaTime;
        
        if (isTrigger) //만약 장애물과 runner가 부딪혔습니다 
        {
            curHP -= 20;
            HandelHP();

            if (hpbar.value <= 0) //만약에 업데이트된 hpbar의 값이 0보다 작으면 디버그로그에 게임오버 출력
            {
                Debug.Log("Game Over!");
                Gameover = true;
            }
            else
            {
                Debug.Log("아직 살아있음");
                
            }
        }
        if(isTrigger2) // 만약 item(힐템)과 runner가 부딪혔으면
        {
            Debug.Log("체력을 올림");

            curHP += 10;
            HandelHP();

            if(hpbar.value >1)
            {
                Debug.Log("이미 최대 체력입니다.");
                hpbar.value = 1;
                isTrigger2 = false;
            }
        }
        if(hpbar.value <= 0)
        {
            Gameover = true;
            SceneManager.LoadScene("GameoverScene");
        }
        else if(hpbar.value > 0)
        {
            Gameover = false;
        }

    }

    private void HandelHP()
    {
        hpbar.value = (float)curHP / (float)maxHP;
        isTrigger = false;
        isTrigger2 = false;
    }
}
