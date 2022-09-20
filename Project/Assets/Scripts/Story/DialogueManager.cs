using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public Text NameText;
    public Text DialogueText;

    public Animator animator;

    public Queue<string> Sentences;
    public Queue<string> Names;

    void Start()
    {
        Sentences = new Queue<string>();
        Names = new Queue<string>();
    }
    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);

        Sentences.Clear();
        Names.Clear();
        foreach(string sentence in dialogue.Sentences)
        {
            Sentences.Enqueue(sentence);
        }
        foreach(string names in dialogue.Names)
        {
            Names.Enqueue(names);
        }
        DisplayNextSentence();
        DisplayNextName();
    }
    public void DisplayNextSentence()
    {
        if(Sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string Sentence = Sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(Sentence));
    }
    public void DisplayNextName()
    {
        if (Names.Count == 0)
        {
            EndDialogue();
            return;
        }
        string Name = Names.Dequeue();
        NameText.text = Name;
    }
    IEnumerator TypeSentence(string Sentence)
    {
        DialogueText.text = "";
        foreach (char letter in Sentence.ToCharArray())
        {
            DialogueText.text += letter;
            yield return null;
        }
    }
    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        SceneManager.LoadScene("StorySelectScene");
    }
}
