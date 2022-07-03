using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class seeorhidechat : MonoBehaviour
{
    public GameObject chatUI;
    
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
    public void click()
    {
        if(chatUI.active = true)
        {
        chatUI.gameObject.SetActive(false);
        }
        else
        {
        chatUI.gameObject.SetActive(true);
        }
    }

 
}
