using UnityEngine;

public class Randomizer : MonoBehaviour
{
    GameObject leftDoor;
    GameObject rightDoor;

    public Transform[] rooms;
    public float InvokeRate = 1.0f;

    GameObject activeRoom;
    GameObject inactiveRoom;

    Animator leftAnim;
    Animator rightAnim;

    void Start()
    {
        Invoke("pickRoom", 10.0f);
    }

    public void pickRoom()
    {
        int indexNumber = Random.Range(0, rooms.Length);

        activeRoom = GameObject.Find(rooms[indexNumber].name);

        // Define doors
        leftDoor = activeRoom.transform.Find("Left_Door").gameObject;
        rightDoor = activeRoom.transform.Find("Right_Door").gameObject;

        // Define animations
        leftAnim = leftDoor.GetComponent<Animator>();
        rightAnim = rightDoor.GetComponent<Animator>();

        // Trigger animations
        leftAnim.SetTrigger("slide");
        rightAnim.SetTrigger("slide");
    }

    /*void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            SlideDoors(false);
        }
    }

    void SlideDoors(bool state)
    {
        leftAnim.SetBool("slide", state);
        rightAnim.SetBool("slide", state);
    }*/

}
