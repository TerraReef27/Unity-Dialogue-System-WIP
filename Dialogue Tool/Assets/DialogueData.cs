using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewDialogueData", menuName = "Dialogue/Dialogue Data")]
public class DialogueData : ScriptableObject
{
    public List<string> dialogueStrings;
    public List<string> respnseStrings;

    public int dialogueStringsSize = 0;
    [HideInInspector] public int currentDialogueStringsSize = 0;

    public int responseStringsSize = 0;
    [HideInInspector] public int currentResponseStringsSize = 0;

    public string speakerName = "";

    Font font;
    Color textColor;


    [HideInInspector] public DialogueTree tree;
    //Create a tree structure with custom data types containing necissary information
}
