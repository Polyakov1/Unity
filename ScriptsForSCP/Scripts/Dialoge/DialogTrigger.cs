using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DialogGame
{
    public class DialogTrigger : MonoBehaviour
    {
        public Dialog dialog;
        public void TriggerDialog()
        {
            FindObjectOfType<DialogManager>().StartDialog(dialog);
        }
        public void Start()
        {
            StartCoroutine(Starting());
        }
        IEnumerator Starting()
        {
            yield return new WaitForSeconds(5);
            TriggerDialog();

        }



        //TO DO
        //Ивенты для TriggerDialog

    }
}
