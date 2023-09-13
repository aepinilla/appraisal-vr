using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerQuestions : MonoBehaviour
{
    public GameObject trigger;
    public GameObject spaceObject;
    public GameObject movementController;

    void Start()
    {
        //movementController = GetComponent<CharacterController>();
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            spaceObject.SetActive(false);
            //movementController.enabled = false;
        }
    }

    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            spaceObject.SetActive(true);
        }
    }

}
