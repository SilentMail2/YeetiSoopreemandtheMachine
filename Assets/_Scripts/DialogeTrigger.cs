using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class DialogeTrigger : MonoBehaviour
{
    public Flowchart flowChart;
    public GameObject EtoTalk;
    public Dialogue[] dialogue;
    public string message;
    public bool dialogueGiven;
    
    public void TriggerDialogue()
    { FindObjectOfType<DialogeManager>().StartDialogue(dialogue[0]); }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            EtoTalk.SetActive(true);

        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                EtoTalk.SetActive(false);
                flowChart.gameObject.SetActive(true);
                other.GetComponent<Player_Control>().inDialogue = true;
                Debug.Log("Lets Talk");//TriggerDialogue();
            }
        }
    }
    public void EndConversation()
    {
        flowChart.gameObject.SetActive(false);
    }
}
