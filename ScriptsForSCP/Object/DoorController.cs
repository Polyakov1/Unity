using Player;
using UnityEngine;
namespace InteractiveItem
{
    public class DoorController : MonoBehaviour
    {
        public float liftSpeed;
        public float lowerSpeed;
        public bool isDoorOpen;
        public float range;

        public Vector3 posX = Vector3.left;
        public AudioSource sound;
        public Vector3 initialPosition;
        public void Awake()
        {
            sound = GetComponent<AudioSource>();
            initialPosition = transform.position;
        }

        public void Update()
        {
            Open();
        }

        public void ToggleDoor()
        {
            isDoorOpen = !isDoorOpen;
        }

        public void Open()
        {
            if (isDoorOpen)
            {
                transform.position = Vector3.Lerp(transform.position, initialPosition + posX * range, Time.deltaTime * liftSpeed);          
                sound.Play();

            }
            else
            {
                transform.position = Vector3.Lerp(transform.position, initialPosition, Time.deltaTime * lowerSpeed);
                sound.Play();
            }
        }
    }
}