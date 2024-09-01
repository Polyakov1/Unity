using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ForButtonInMenu
{
    public class ClickedButton : MonoBehaviour
    {
       private void NewLevel(string level)
        {
            SceneManager.LoadSceneAsync(level);
        }
        public void ActivateButton(string level)
        {

            NewLevel(level);
        }

        public void OnApplicationQuit()
        {
            Application.Quit();
        }
        public void OpenPanel(GameObject panel)
        {
            panel.SetActive(!panel.activeSelf);
        }

        
    }
    
    

}
