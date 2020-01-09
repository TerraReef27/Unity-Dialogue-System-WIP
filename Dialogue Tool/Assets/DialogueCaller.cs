using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueCaller : MonoBehaviour
{
    [Tooltip("Set the z to any positive number for a 2D game")]
    public Vector3 interactionRange = new Vector3(1, 1, 1);

    private DialogueManager manager = null;

    private void Awake()
    {
        FindDialogueManager();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CallForDialogue();
        }
    }

    public void CallForDialogue()
    {
        DialogueObject objectToTalkTo = null;
        objectToTalkTo = GetObjectToTalkTo(objectToTalkTo);

        if(objectToTalkTo)
            objectToTalkTo.Talk();
    }

    private DialogueObject GetObjectToTalkTo(DialogueObject objectToTalkTo)
    {
        DialogueObject[] dialogueObjects = FindObjectsOfType<DialogueObject>();
        DialogueObject[] objectsInRange = new DialogueObject[dialogueObjects.Length];
        int numObjectsInRange = 0;

        foreach(DialogueObject obj in dialogueObjects)
        {
            Vector3 pos = obj.gameObject.transform.position;
            Vector3 radius = transform.position;

            if((pos.x - radius.x <= interactionRange.x/2 && pos.x - radius.x >= -interactionRange.x/2) && (pos.y - radius.y <= interactionRange.y/2 && pos.y - radius.y >= -interactionRange.y/2) && (pos.z - radius.z <= interactionRange.z/2 && pos.z - radius.z >= -interactionRange.z/2))
            {
                objectToTalkTo = obj;
                objectsInRange[numObjectsInRange] = obj;
                numObjectsInRange++;
            }
        }

        //Finds the closer of the objects in range
        if(numObjectsInRange > 1)
        {
            float closestObject = Vector2.Distance(gameObject.transform.position, objectsInRange[0].transform.position);
            int objectNum = 0;

            for(int i = 0; i < numObjectsInRange; i++)
            {
                if(closestObject > Vector2.Distance(gameObject.transform.position, objectsInRange[i].transform.position))
                {
                    closestObject = Vector2.Distance(gameObject.transform.position, objectsInRange[i].transform.position);
                    objectNum = i;
                }
            }
            objectToTalkTo = objectsInRange[objectNum];
        }

        return objectToTalkTo;
    }

    private void FindDialogueManager()
    {
        manager = FindObjectOfType<DialogueManager>();
        if (manager == null)
        {
            throw new Exception("There is no Dialogue Manager in scene");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 255, 255, .3f);
        Gizmos.DrawCube(transform.position, interactionRange);
    }
}
