using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
namespace Player
{
    public class Iventory : MonoBehaviour
    {

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                SeeAllBug();
            }
        }

        public static Dictionary<int, string> inventory = new Dictionary<int, string>();

        public static void AddItem(int pos, string name)
        {
            try
            {
                inventory.Add(pos, name);
            }
            catch
            {
                Debug.Log("Error");
            }
        }
        public static Dictionary<int, string> GetItem()
        {
            return inventory;
        }

        public static void RemoveItem(int pos)
        {
           inventory.Remove(pos);
        }
        public static void SeeAllBug()
        {
            foreach (var item in inventory)
            {
                Debug.Log(item.ToString());
            }
        }

    }
}