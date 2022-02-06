using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    private inwintary inwintary;
    public GameObject slotButton;


    private void Start()
    {
        GameManager.PlayerCreated += OnPlayerCreated;
        
    }
    private void OnDestroy()
    {
        GameManager.PlayerCreated -= OnPlayerCreated;
    }
    private void OnPlayerCreated()
    {
        var player = GameObject.FindGameObjectWithTag("Player");
        inwintary = player.GetComponent<inwintary>();
        Debug.Log($" Start{inwintary}");
    }

    public void OnServerInitialized()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($" On Enter {other.name}");
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inwintary.slots.Length; i++)
            {
                if (inwintary.isFull[i] == false)
                {
                    inwintary.isFull[i] = true;
                    Instantiate(slotButton, inwintary.slots[i].transform);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}