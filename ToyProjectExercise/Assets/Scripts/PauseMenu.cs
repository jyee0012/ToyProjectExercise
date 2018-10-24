using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField]
    GameObject pausePanel;
    bool paused;
    private void Start()
    {
        paused = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
        if (paused)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0;
            //Cursor.visible = true;
            //Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1;
            //Cursor.visible = false;
            //Cursor.lockState = CursorLockMode.Locked;
        }
    }
    public void PauseGame()
    {
        paused = !paused;
    }
    public void ReturnToTitle()
    {
        SceneManager.LoadScene(0);
    }

    public void Resume ()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
        paused = false;
    }

}
