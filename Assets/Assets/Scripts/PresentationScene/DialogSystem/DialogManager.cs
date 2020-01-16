using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Text NameTxt, DialogTxt;

    Queue<string> Sentences;

    // Use this for initialization
    void Start()
    {
        Sentences = new Queue<string>();
    }

    public void StartDialog(Dialogue dialogue)
    {
        NameTxt.text = dialogue.name;

        Sentences.Clear();

        foreach (string sentence in dialogue.Sentences)
        {
            Sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (Sentences.Count == 0)
        {
            EndDialog();
            return;
        }
        string sentence = Sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        DialogTxt.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            DialogTxt.text += letter;
            yield return null;
        }
    }

    public void EndDialog()
    {
        Debug.Log("it's over");
    }
}
