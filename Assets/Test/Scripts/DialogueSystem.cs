using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public GameObject dialogueBox;
    public Animator animator;
    public TMP_Text dialogueText;

    public void DialogueBox(string Text)
    {
        dialogueBox.SetActive(true);
        dialogueText.text = Text;
        animator.SetTrigger("pop");
    }
}
