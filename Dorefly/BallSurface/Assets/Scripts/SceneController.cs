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

}
