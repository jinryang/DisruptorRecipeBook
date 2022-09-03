using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject Cover;
    public Dialogue dialogue;
    public void TriggerDialogue()
    {
        Cover.SetActive(false);
        this.gameObject.transform.SetAsFirstSibling();
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

}
