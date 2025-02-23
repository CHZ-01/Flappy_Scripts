using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public GameObject gameover;

    //restart function
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //quit function
    public void quit()
    {
        Application.Quit();
    }

    //gameover screen
    public void Gameover()
    {
        gameover.SetActive(true);
    }
}
