using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTask : MonoBehaviour
{
    public void LoadExpTask()
    {
        SceneManager.LoadScene("SceneLoader");
    }
}
