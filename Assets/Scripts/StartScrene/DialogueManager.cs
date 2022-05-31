using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Assets.Scripts.StartScrene
{
    public class DialogueManager : MonoBehaviour
    {
        public TMP_Text nameText;
        public TMP_Text dialogueText;
        public Canvas textCanvas;
        public Canvas startcanvas;
        
        private Queue<string> sentences;

        private void Start()
        {
            sentences = new Queue<string>();
            textCanvas.enabled = true;
        }

        public void StartDailogue(Dialogue dialogue)
        {
            
            nameText.text = dialogue.nname;
            sentences.Clear();
            foreach (string sentence in dialogue.sentences)
            {
                sentences.Enqueue(sentence);
                displayNextSentence();
            }
        }

        public void displayNextSentence()
        {
            if(sentences.Count == 0)
            {
                EndDialouge();
                return;
            }

            string sentence = sentences.Dequeue();
            dialogueText.text = sentence;
        }

        /*IEnumerator typeSentence(string sentence)
        {
            dialogue.text
        }*/ 

        public void EndDialouge()
        {
            Debug.Log("End of COnversation");
        }
    }
}