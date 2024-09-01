using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    [Header("Level Settings")]
    public GameObject[] lvl;



    private void CreateMap(float sizeMap)
    {
        Instantiate(GameObject.Find("Start"), transform.position, lvl[0].transform.rotation);
        for (int i = 0; i < sizeMap; i++)
        {
            int lvlIndex = Random.Range(0, lvl.Length);
            Instantiate(lvl[lvlIndex], transform.position, lvl[lvlIndex].transform.rotation);
        }
        Instantiate(GameObject.Find("End"), transform.position, lvl[1].transform.rotation);
    }

    private void Awake()
    {
        
        CreateMap(5.0f);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
