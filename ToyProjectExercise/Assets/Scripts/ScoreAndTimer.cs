using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreAndTimer : MonoBehaviour {
    //Attach to Game Scene
    int currP1;
    int currP2;
    public static bool p2Active;

    [SerializeField]
    GameObject timeText;
    [SerializeField]
    GameObject p1ScoreText;
    [SerializeField]
    GameObject p2ScoreText;

    public float timer;

    void Start () {
        currP1 = 0;//first time setup of p1Score. Use if p1Score == -1 to check if a game has been played or not.
        if (ScoreStatics.p2Active) currP2 = 0;
        else currP2 = -1;
        timer = 60.0f;
    }
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            ScoreStatics.p1Score = currP1;
            ScoreStatics.p2Score = currP2;
            SceneManager.LoadScene("GameOverScene");//Replace GameOverScene with name of scene that displays results.
        }
        p1ScoreText.GetComponent<Text>().text = "Player 1 Score\n" + currP1.ToString();
        if (p2Active) p2ScoreText.GetComponent<Text>().text = "Player 2 Score\n" + currP2.ToString();
        else p2ScoreText.SetActive(false);
        timeText.GetComponent<Text>().text = "Time remaining\n" + ((int)timer).ToString();
    }


    public void AddScore(int player)
    {
        if (player == 1) currP1 += 100;
        else currP2 += 100;
    }
}
