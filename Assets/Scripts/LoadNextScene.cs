using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadNextScene : MonoBehaviour
{
    private float currentSceneIndex;
    private string thisScene;
    private string startTime;
    private int duration = 20;

    public Animator animator;

    void Start()
    {
        // This will be used in Questionnaire.cs
        thisScene = SceneManager.GetActiveScene().name;
        startTime = DateTime.UtcNow.ToString("yyyy-MM-dd,HH.mm.ss");

        PlayerPrefs.SetString("LastScene", thisScene);
        PlayerPrefs.SetString("StartTime", startTime);

        currentSceneIndex = PlayerPrefs.GetFloat("CurrentSceneIndex");
        currentSceneIndex += 1;
        PlayerPrefs.SetFloat("CurrentSceneIndex", currentSceneIndex);

        if (currentSceneIndex < 10)
        {
            Invoke("LoadSAM", duration);
        }
    }

    void LoadSAM()
    {
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene("SAMScene");
    }

}
