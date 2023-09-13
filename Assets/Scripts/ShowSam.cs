using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowSam : MonoBehaviour
{
    public GameObject trigger;

    void Start()
    {
        Debug.Log("Show SAM");
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("Show SAM2");
//            Invoke("loadSamQuestions", 5.0f);
        }
    }

   /* public void loadSamQuestions()
    {
        //SceneManager.LoadScene("SAMScene");
        Debug.Log("Show SAM");
    }*/
}
