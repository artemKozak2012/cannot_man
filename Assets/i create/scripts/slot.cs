using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slot : MonoBehaviour
{
    private inwintary inwintary;
    public int i;
    public int delay;

  

    private void Awake()
    {
        GameManager.PlayerCreated += OnPlayerCreated;

    }

    private void OnPlayerCreated()
    {
        var player = GameObject.FindGameObjectWithTag("Player");
        var inv = player.GetComponent<inwintary>();
        inv.slots = new GameObject[] { transform.gameObject };
    }

  

    private void OnDestroy()
    {
        GameManager.PlayerCreated -= OnPlayerCreated;
    }

    private void Start()
    {
        inwintary = GameObject.FindGameObjectWithTag("Player").GetComponent<inwintary>();
    }

   

    public void DropItem()
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<No>().SpawnDroppedItem();
            GameObject.Destroy(child.gameObject);
        }  
    }
   
}