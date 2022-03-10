using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverCreator : HPbar
{
    public Transform GameOverImage;

    void Start()
    {

    }

    void Update()
    {
        if (Gameover == true)
            CreateImage();
    }

    void CreateImage()
    {
        Instantiate(GameOverImage);
    }
}
