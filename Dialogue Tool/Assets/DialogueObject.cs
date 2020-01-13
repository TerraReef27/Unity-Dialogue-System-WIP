using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class DialogueObject : MonoBehaviour
{
    [SerializeField] private DialogueData data = null;

    public Vector3 interacableRange = new Vector3 (1, 1, 1);

    private int currenetLine = 0;

    private DialogueManager manager = null;

    private void Awake()
    {
        FindDialogueManager();
    }

    public void Talk()
    {
        if(data.dialogueStrings.Count > 0)
        {
            if (currenetLine >= data.dialogueStringsSize)       //Safty Check
                currenetLine = data.dialogueStringsSize - 1;

            if((currenetLine == data.dialogueStringsSize) && (manager.state == DialogueManager.DialogueState.showing))
            {
                manager.HideDialogue();
                currenetLine--;
            }
            else if(currenetLine < data.dialogueStringsSize)
            {
                manager.ShowDialogue(data, currenetLine);
                currenetLine++;
            }
        }
    }

    private void FindDialogueManager()
    {
        manager = FindObjectOfType<DialogueManager>();
        if (manager == null)
        {
            throw new Exception("There is no Dialogue Manager in scene");
        }
    }
}
