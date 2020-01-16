using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialogue TheDialogue;

    public void TriggerDialog()
    {
        FindObjectOfType<DialogManager>().StartDialog(TheDialogue);
    }
}
