using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTemp : HPbar
{
    public float Time1 = 0.1f;
    public float Time2 = 0.1f;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }



    // Update is called once per frame
    void Update()
    {
        if (Gameover == false)
        {
            //일정시간으로 증가
            if (Time2 < Time.time)
            {
                score += 100;
                Time1 = 0.1f;//반복시간//
                Time2 = Time1 + Time.time;

            }

        }
    }

}
