using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadPracticeScene : MonoBehaviour
{
    private float currentSceneIndex;
    private int duration = 20;

    public Animator animator;

    void Start()
    {
        currentSceneIndex = PlayerPrefs.GetFloat("CurrentSceneIndex");
        currentSceneIndex += 1;
        PlayerPrefs.SetFloat("CurrentSceneIndex", currentSceneIndex);

        Invoke("LoadPracticeSAM", duration);
    }

    void LoadPracticeSAM()
    {
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene("SAMScenePractice");
    }

}
