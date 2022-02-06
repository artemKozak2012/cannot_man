using System;
using UnityEngine;

public class No : MonoBehaviour
{
    public GameObject item;
    private PlayerController player;
   

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

   


    public void SpawnDroppedItem()
    {
        int right =0;
        if (player.FacingRight)
        {
            right = 3;
        }
        else
        {
            right = -4;
        }
        
        Vector2 playerPos = new Vector2(player.transform.position.x + right, player.transform.position.y -1);
        Instantiate(item, playerPos, Quaternion.identity);
    }
    
} 
