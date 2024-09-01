using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace DialogGame
{
    public class DialogManager : MonoBehaviour
    {
        public TMP_Text nameText;
        public TMP_Text dialogText;

        public Animator animator;

        private Queue<string> sentences;
        public KeyCode talk = KeyCode.G;

        private void Start()
        {
            sentences = new Queue<string>();
        }
        public void StartDialog(Dialog dialog)
        {
            animator.SetBool("IsOpen", true);

            nameText.text = dialog.name;
            sentences.Clear();

            foreach (string sentence in dialog.sentences)
            {
                sentences.Enqueue(sentence);
            }
            DisplayNextSentences();
        }
        public void DisplayNextSentences()
        {
            if (sentences.Count == 0)
            {
                EndDialog();
                return;
            }
            string sentence = sentences.Dequeue();
            StopAllCoroutines();
            StartCoroutine(TypeSentence(sentence));
        }

        IEnumerator TypeSentence(string sentence)
        {
            dialogText.text = "";
            foreach (char letter in sentence.ToCharArray())
            {
                dialogText.text += letter;
                yield return null;
            }
        }

        void EndDialog() { animator.SetBool("IsOpen", false); }


        private void Update()
        {
            if (Input.GetKeyDown(talk))
            {
                DisplayNextSentences();
            }
        }
    }
}