using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slot : MonoBehaviour
{
    private inwintary inwintary;
    public int i;

    private void Awake()
    {
        GameManager.PlayerCreated += OnPlayerCreated;

    }

    private void OnPlayerCreated()
    {
        var player = GameObject.FindGameObjectWithTag("Player");
        var inv = player.GetComponent<inwintary>();
        inv.slots = new GameObject[] { gameObject };
    }

    private void OnDestroy()
    {
        GameManager.PlayerCreated -= OnPlayerCreated;
    }

    private void Start()
    {
        inwintary = GameObject.FindGameObjectWithTag("Player").GetComponent<inwintary>();
    }

    private void Update()
    {
        if (transform.childCount <= 0)
        {
            inwintary.isFull[i] = false;
        }
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