using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void ButtonStart()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonQuit()
    {
        Debug.Log("Quitamos la aplicacion");
        Application.Quit();
    }

    public void ButtonLevel1()
    {
        SceneManager.LoadScene(2);
    }

    public void ButtonGym()
    {
        SceneManager.LoadScene(4);
    }

    public void ButtonLevel2()
    {
        SceneManager.LoadScene(3);
    }
}
