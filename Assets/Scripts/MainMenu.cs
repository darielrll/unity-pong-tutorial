using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void PlayerVSIA()
    {
        SceneManager.LoadScene("PlayerVSIA");
    }

    public void PlayerVSIPlayer()
    {
        SceneManager.LoadScene("PlayerVSPlayer");
    }
}
