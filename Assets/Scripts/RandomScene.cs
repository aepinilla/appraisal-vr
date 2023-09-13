using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomScene : MonoBehaviour
{
    private List<string> order = new List<string> {"Stressing", "Exciting", "Calming", "Depressing", "Neutral"};
    private string startScene;

    void Start()
    {
        for (int i = 0; i < order.Count; i++)
        {
            string temp = order[i];
            int randomIndex = Random.Range(i, order.Count);
            order[i] = order[randomIndex];
            order[randomIndex] = temp;
        }

        PlayerPrefs.SetString("FirstScene", order[0]);

        PlayerPrefs.SetString("SecondScene", order[1]);

        PlayerPrefs.SetString("ThirdScene", order[2]);

        PlayerPrefs.SetString("FourthScene", order[3]);

        PlayerPrefs.SetString("FifthScene", order[4]);

        PlayerPrefs.SetFloat("CurrentSceneIndex", 0.0f);
    }

    void Update()
    {
        startScene = PlayerPrefs.GetString("FirstScene");
        SceneManager.LoadScene(startScene);
    }


}
