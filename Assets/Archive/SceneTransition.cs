using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public Animator animator;
    private int sceneToLoad;
    
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One))
        {
            FadeToLevel(15);
        }
    }

    public void FadeToLevel (int levelIndex)
    {
        sceneToLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
