using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    AudioSource titlemusic;

    void Start()
    {
        titlemusic = GetComponent<AudioSource>();
        titlemusic.Play();
    }
    public void StarGame()
    {
        SceneManager.LoadScene(3);  // On charge la scene avec l' index 1 dans le buildsettings du projet
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
