using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public Canvas main;
    public Canvas settings;

    // Start is called before the first frame update
    void Start()
    {
        main.enabled = true;
        settings.enabled = false;
    }

    public void OnPlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnSettings()
    {
        main.enabled = false;
        settings.enabled = true;
    }

    public void OnExit()
    {
        Application.Quit();
    }

    public void OnBackToMain()
    {
        main.enabled = true;
        settings.enabled = false;
    }
}
