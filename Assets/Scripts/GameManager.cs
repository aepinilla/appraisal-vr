using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CHARACTERTYPE
{
    _none = -1,
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private ParticipantData[] participantData;
    [SerializeField] private CHARACTERTYPE[] participants;
    private ParticipantData[] currentParticipants;

    [System.Serializable]
    public struct ParticipantData
    {
        public int participant;
        public string room;
        public int arousal;
        public int valence;
        public int dominance;
    }

    /*void Awake()
    {
        instance = this;
        currentParticipants = new ParticipantData[participants.Length];
        for (int i = 0; i < currentParticipants.Length; i++)
        {
            currentParticipants[i] = participantData[(int)participants[i]];
        }
    }*/
    
    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //Interact();
            CSVManager.AppendToReport(GetReportLine());
            Debug.Log("<color=magenta>Report updated!</color>");
        }
    }
    */

    /*void Interact()
    {
        //currentParticipants[0].hp -= Mathf.Max(Random.Range(1, currentParticipants[1].damage + 1) - currentParticipants[0].armor, 0);
        //currentParticipants[1].hp -= Mathf.Max(Random.Range(1, currentParticipants[0].damage + 1) - currentParticipants[1].armor, 0);
    }*/



}
