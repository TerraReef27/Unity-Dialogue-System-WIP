using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private Image dialoguePanel = null;
    [SerializeField] private TextMeshProUGUI dialogueText = null;

    [SerializeField] private Image namePanel = null;
    [SerializeField] private TextMeshProUGUI nameText = null;

    public enum DialogueState { hidden, showing }
    public DialogueState state;

    void Awake()
    {
        dialoguePanel = GetComponentInChildren<Image>();
        dialogueText = GetComponentInChildren<TextMeshProUGUI>(); 
    }

    void Start()
    {
        HideDialogue();
    }

    public void ShowDialogue(DialogueData data, int currentDialogueLine)
    {
        state = DialogueState.showing;
        dialoguePanel.gameObject.SetActive(true);
        dialogueText.gameObject.SetActive(true);

        namePanel.gameObject.SetActive(true);
        nameText.gameObject.SetActive(true);

        dialogueText.text = data.dialogueStrings[currentDialogueLine];
        nameText.text = data.speakerName;
    }

    public void HideDialogue()
    {
        state = DialogueState.hidden;
        dialoguePanel.gameObject.SetActive(false);
        dialogueText.gameObject.SetActive(false);

        namePanel.gameObject.SetActive(false);
        nameText.gameObject.SetActive(false);
    }
}
