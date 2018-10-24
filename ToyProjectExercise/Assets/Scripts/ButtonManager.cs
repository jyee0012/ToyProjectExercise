using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu Exercise");
    }

    //public void PlayOpening()
    //{
    //    SceneManager.LoadScene("Opening");
    //}

    //public void MainMenu()
    //{
    //    SceneManager.LoadScene("MainMenu");
    //}

    public void QuitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
