using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Score : MonoBehaviour
{
    // 처음 시작하는 숫자 00000000의 이미지를 담을 NumberImage 선언 
    public GameObject[] NumberImage;
    // 0부터 9까지의 숫자 이미지를 담을 Number 선언 
    public Sprite[] Number;

    private void Update()
    {
        // 점수의 각 자리 수를 저장하기 위한 배열 scores
        // 10000000 => scores[0], 1000000 => scores[1], 100000 => scores[2], ... 1 => scores[7]
        int[] scores = new int[8];
        // 시작버튼을 누를 때부터의 점수 score 저장하고 있는 스크립트 Score에서 점수 불러옴.
        scores[7] = GameObject.Find("Score").GetComponent<ScoreTemp>().score;

        for(int i = 7; i >0; i--)
        {
            scores[i - 1] = scores[i] / 10;
            scores[i] = scores[i] % 10;
        }

        for(int i = 0; i < 8; i++)
        {
            // NumberImage의 00000000 배열 이미지를 각 자리 수에 해당하는 인덱스 번호의 number 이미지로 변환함
            NumberImage[i].GetComponent<SpriteRenderer>().sprite = Number[scores[i]];
        }
    }
}
