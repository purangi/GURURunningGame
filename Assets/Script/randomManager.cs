using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomManager 
{
    
    //랜덤 숫자 반환 함수
    public float randomNum(int firstNum, int endNum)
    {
        System.Random random = new System.Random();
        return (float)(random.Next(firstNum, endNum) * 0.01);
    }

}
