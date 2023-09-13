using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Temporizer : MonoBehaviour
{

    void Start()
    {
        Invoke("LoadReadyScreen", 10.0f);
    }
        
    void LoadReadyScreen()
    {
        SceneManager.LoadScene("ReadyScene");
    }
}
