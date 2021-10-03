using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBehaviour : MonoBehaviour
{
    private int nextSceneIndex;
    private int previousSceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        previousSceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
    }

    public void OnNextButtonPressed()
    {
        SceneManager.LoadScene(nextSceneIndex);
    }

    public void OnBackButtonPressed()
    {
        SceneManager.LoadScene(previousSceneIndex);
    }
}
