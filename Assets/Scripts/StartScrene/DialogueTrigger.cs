using System.Collections;
using UnityEngine;

namespace Assets.Scripts.StartScrene
{
    public class DialogueTrigger : MonoBehaviour
    {

        [SerializeField] Dialogue dialogue;

        public void triggerDialogue()
        {
            FindObjectOfType<DialogueManager>().StartDailogue(dialogue);
        }
    }
} 