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
