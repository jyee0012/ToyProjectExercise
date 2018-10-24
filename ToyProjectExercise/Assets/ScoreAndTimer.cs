using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreAndTimer : MonoBehaviour {
    //Attach to Game Scene
    public static int p1Score;
    public static int p2Score;
    public float timer;

    void Start () {
        p1Score = 0;//first time setup of p1Score. Use if p1Score == -1 to check if a game has been played or not.
        p2Score = 0;
        timer = 60.0f;
    }
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SceneManager.LoadScene("GameOverScene");//Replace GameOverScene with name of scene that displays results.
        }
	}


    public static void AddScore(int player)
    {
        if (player == 1) p1Score += 100;
        else p2Score += 100;
    }
}
