using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivateParticles : MonoBehaviour
{
    public GameObject trigger;
    public ParticleSystem ps;
    public string currentRoom;

    void Start()
    {
        ps.Stop();
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            ps.Play();
        }

        if (coll.gameObject.tag == "Player")
        {
            Invoke("loadSam", 10.0f);
        }

        if (coll.gameObject.tag == "Player")
        {
           PlayerPrefs.SetString("room", currentRoom);
        }
    }

    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            ps.Stop();
        }
    }

    public void loadSam()
    {
        SceneManager.LoadScene("SAMScene");
    }
}
