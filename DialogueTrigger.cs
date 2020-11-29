using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueTrigger : MonoBehaviour
{
    


    public Dialogue dialogue;

    void Start() {
        TriggerDialogue(); {

        }
    }

    public void TriggerDialogue() {
        
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        

    }


}
