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
    public void hideChat()
    {
        chatUI.gameObject.SetActive(false);
    }
    public void seeChat()
    {
        chatUI.gameObject.SetActive(true);
    }
}
