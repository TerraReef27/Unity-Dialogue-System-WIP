using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewDialogueData", menuName = "Dialogue/Dialogue Data")]
public class DialogueData : ScriptableObject
{
    public List<string> dialogueStrings;

    public int dialogueStringsSize = 0;
    [HideInInspector] public int currentStringsSize = 0;

    public string speakerName = "";

    Font font;
    Color textColor;
    
    //Create a tree structure with custom data types containing necissary information
}
