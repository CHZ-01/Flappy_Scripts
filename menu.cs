using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadSceneAsync(1);//game retstart
    }

    public void quit()
    {
        Application.Quit();//game quit
    }
}
