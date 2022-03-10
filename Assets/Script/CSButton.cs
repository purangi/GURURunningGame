using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class CSButton : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void CreditScene()
    {
        SceneManager.LoadScene("CreditScene");
    }

    public void RetryScene()
    {
        GameObject.Destroy(GameObject.Find("Score"));
        SceneManager.LoadScene("GameScene");
    }

    public void GobackBtn()
    {
        SceneManager.LoadScene("GameoverScene");
    }
}