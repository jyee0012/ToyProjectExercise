using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

    [SerializeField]
    GameObject scoreText;

    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void SetPlayerCount(int count)
    {
        if (count == 1) ScoreStatics.p2Active = false;
        else ScoreStatics.p2Active = true;
    }


    void Update()
    {
<<<<<<< HEAD
        if (SceneManager.GetActiveScene().name == "ResultsScreen")
=======
        if (SceneManager.GetActiveScene().name == "ResultsScene")
>>>>>>> 640905d5e6c6a3aef2cc57d0b4bce87db093729d
        {
            if (!ScoreStatics.p2Active) scoreText.GetComponent<Text>().text = "Your Score: " + ScoreStatics.p1Score.ToString();
            else scoreText.GetComponent<Text>().text = "Player 1 Score: " + ScoreStatics.p1Score.ToString() + "\nPlayer 2 Score: " + ScoreStatics.p2Score.ToString();
        }
    }



    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
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
