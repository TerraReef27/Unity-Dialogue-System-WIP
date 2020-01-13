using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DialogueMethods
{
    public static void SetDialogueStringSize(DialogueData data)
    {
        while (data.currentDialogueStringsSize != data.dialogueStringsSize)
        {
            if (data.currentDialogueStringsSize < data.dialogueStringsSize)
            {
                data.dialogueStrings.Add("");
                data.currentDialogueStringsSize++;
            }
            else if (data.currentDialogueStringsSize > data.dialogueStringsSize)
            {
                data.dialogueStrings.RemoveAt(data.currentDialogueStringsSize - 1);
                data.currentDialogueStringsSize--;
            }
        }
    }

    public static void SetResponseStringSize(DialogueData data)
    {
        while (data.currentResponseStringsSize != data.responseStringsSize)
        {
            if (data.currentResponseStringsSize < data.responseStringsSize)
            {
                data.respnseStrings.Add("");
                data.currentResponseStringsSize++;
            }
            else if (data.currentResponseStringsSize > data.responseStringsSize)
            {
                data.respnseStrings.RemoveAt(data.currentResponseStringsSize - 1);
                data.currentResponseStringsSize--;
            }
        }
    }
}
