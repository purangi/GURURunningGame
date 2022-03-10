using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    // 게임 플레이 상태를 나타내는 변수 선언
    // 이후에 시작 버튼 누른 후에 isPlaying이 true일 때만 게임 작동하도록 합쳐줘야 함. 
    public bool isPlaying = false;
    public GameObject playBtn;

    // 점수를 저장할 변수 score 선언
    public int score = 0;
    // Start is called before the first frame update
    IEnumerator AddScore()
    {
        // canvas의 StartButton 스크립트에서 isPlaying 변수를 가져온다.
        // 게임이 실행 중인 경우 0.1초에 점수가 100점씩 추가된다.  
        while (isPlaying)
        {
            score = score + 100;
            yield return new WaitForSeconds(0.1f);
        }
    }

    // 임의의 시작 버튼을 만들어 버튼이 눌린 경우 게임이 실행되었다는 상태를 저장하는 함수를 불러옴.
    // 프로젝트 합치는 과정에서 메인 화면의 시작 버튼에 스크립트를 다시 연결해주어야 함.
    public void PlayBtnClick()
    {
        isPlaying = true;
        StartCoroutine(AddScore());
    }
}

// 플레이버튼과 연결될 게임 시작 함수와 게임 오버 함수에서 점수 증가를 시작/ 종료하도록 아래의 주석 적용해 주어야 함.
// canvas에 연결된 StartButton 스크립트의 PlayBtnClick 함수 참고. 
/*
public void PlayBtnClick()
{
    isPlaying = true;
    StartCoroutine(AddScore());
}
public void GameOver()
{
    isplaying = false;
    StopCoroutine(AddScore())
}
*/
