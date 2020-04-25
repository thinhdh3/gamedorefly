using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void loadScenePlay()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }

    private void Start()
    {
        Time.timeScale = 0.0f;
    }

    public void startGame()
    {
        Time.timeScale = 1.0f;
        gameObject.SetActive(false);
    }
}
