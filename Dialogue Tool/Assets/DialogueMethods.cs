using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DialogueMethods
{
    public static void SetDialogueStringSize(DialogueData data)
    {
        while (data.currentStringsSize != data.dialogueStringsSize)
        {
            if (data.currentStringsSize < data.dialogueStringsSize)
            {
                data.dialogueStrings.Add("");
                data.currentStringsSize++;
            }
            else if (data.currentStringsSize > data.dialogueStringsSize)
            {
                data.dialogueStrings.RemoveAt(data.currentStringsSize - 1);
                data.currentStringsSize--;
            }
        }
    }
}
