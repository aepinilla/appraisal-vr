using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowQuestions : MonoBehaviour
{

    public GameObject questionsPanel;
    public static bool disabled = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (disabled)
            questionsPanel.SetActive(false);
        else
            questionsPanel.SetActive(true);
    }
}
