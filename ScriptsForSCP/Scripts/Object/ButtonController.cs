using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
namespace InteractiveItem
{

    public class ButtonController : MonoBehaviour, IActive
    {
        public GameObject door;
        private GameObject interactionText;
        private bool isPlayerNear = false;
        private GameObject player;
        private void Start()
        {
            interactionText = GameObject.Find("Player/Canvas/Activate");

        }
        void Update()
        {
            Activate();
        }
        public void Activate()
        {
            if (isPlayerNear && Input.GetKeyDown(KeyCode.E))
            {
                door.GetComponent<DoorController>().ToggleDoor();
            }
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                isPlayerNear = true;
                interactionText.SetActive(true);
            }
            else
            {
                Debug.Log("Else");
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                isPlayerNear = false;
                interactionText.SetActive(false);
            }
        }
    }
}