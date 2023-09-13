using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivateParticlesPractice : MonoBehaviour
{
    public GameObject trigger;

    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.Y))
        {
            SceneManager.LoadScene("SAMScenePractice");
        }
    }

    /*void OnTriggerEnter(Collider coll)
    {
 
        if (coll.gameObject.tag == "Player")
        {
            Invoke("loadSamPrac", 10.0f);
        }
    }*/

    
}
