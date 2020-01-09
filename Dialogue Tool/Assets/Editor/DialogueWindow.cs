using UnityEngine;
using UnityEditor;
using System;

public class DialogueWindow : EditorWindow
{
    private DialogueData currentObject = null;
    private int preupdateNumber;

    [MenuItem("Window/Dialogue")]

    public static void ShowWindow()
    {
        GetWindow<DialogueWindow>("Dialogue");
    }

    private void OnGUI()
    {
        if(currentObject)
        {
            DisplayObjectDialogue();
        }
    }

    private void DisplayObjectDialogue()
    {
        GUILayout.Label("Name", EditorStyles.boldLabel);
        currentObject.speakerName = GUILayout.TextField(currentObject.speakerName);

        GUILayout.Label("Dialogue Strings", EditorStyles.boldLabel);

        GUILayout.Label("Number of strings");
        currentObject.dialogueStringsSize = EditorGUILayout.IntField(currentObject.dialogueStringsSize);
        if(GUILayout.Button("Update List Size"))
        {
            DialogueMethods.SetDialogueStringSize(currentObject);
            preupdateNumber = currentObject.dialogueStringsSize;
            //UpdateDialogueTextFields();
        }
        for (int i = 0; i < preupdateNumber; i++)
        {
            currentObject.dialogueStrings[i] = EditorGUILayout.TextArea(currentObject.dialogueStrings[i]);
        }
    }

    private void OnSelectionChange()
    {
        foreach(UnityEngine.Object obj in Selection.objects)
        {
            Debug.Log(obj);
            if(obj.GetType().Equals(typeof(DialogueData)))
            {
                Debug.Log("Is Dialogue");
                currentObject = (DialogueData)obj;
                break;
            }
        }
    }
}
