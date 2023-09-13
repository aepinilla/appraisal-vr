using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TogglePanel : MonoBehaviour
{

    public void LoadInstrO2()
    {
        SceneManager.LoadScene("Intro2");
    }

    public void LoadCode()
    {
        SceneManager.LoadScene("CodeSelector");
    }

    public void LoadInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void LoadPractice()
    {
        SceneManager.LoadScene("Practice");
    }

}
