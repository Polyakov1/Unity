using InteractiveItem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamps : MonoBehaviour, IActive
{

    private void Start()
    {
        InvokeRepeating(nameof(Activate), Random.Range(2f, 4f), Random.Range(2f, 4f));
    }
    public void Activate()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }



}
