/* 
GAME2014-F2021-Assignment1 by Jen Marc Capistrano
Student #: 101218004
Last Modified: 3 October 2021
Course: GAME2014-F2021-Tom Tsiliopoulos

Program Description:
This is a clone or-so of Space Invaders made for mobile

Script Description:
This is for the UI buttons to transverse to different scenes
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBehaviour : MonoBehaviour
{
    private int nextSceneIndex;
    private int previousSceneIndex;
    private int tutorialSceneIndex;
    private int titleSceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        previousSceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
        tutorialSceneIndex = 3;
        titleSceneIndex = 0;
}

    public void OnNextButtonPressed()
    {
        SceneManager.LoadScene(nextSceneIndex);
    }

    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene(previousSceneIndex);
    }

    public void OnTutorialButtonPressed()
    {
        SceneManager.LoadScene(tutorialSceneIndex);
    }

    public void OnTitleMenuButtonPressed()
    {
        SceneManager.LoadScene(titleSceneIndex);
        
    }

    public void OnQuitButtonPressed()
    {
        Application.Quit();
    }
}
