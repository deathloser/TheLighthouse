using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;
    public GameObject dialogueBox;
    public Queue<string> sentences;
    public GameObject moveButton;

    private void Start() {
        sentences = new Queue<string>();
        dialogueBox.SetActive(true);
        moveButton.SetActive(false);

    }

    public void StartDialogue(Dialogue dialogue) {

        sentences.Clear();

        foreach(string sentence in dialogue.sentences) {
            //fill the queue with the sentences[] array from dialogue
            sentences.Enqueue(sentence);

        }
        DisplayNextSentence();

    }
    public void DisplayNextSentence() {
        if (sentences.Count == 0 ) {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;

    }

    public void EndDialogue() {
        Debug.Log("End of dialogue");
        dialogueBox.SetActive(false);
        moveButton.SetActive(true);


    }

}
