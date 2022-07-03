using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscenes : MonoBehaviour
{
    
  public void reloadscene1()
    {
        SceneManager.LoadScene("SampleScene");  
    }

    
    public void reloadscene2()
    {
        SceneManager.LoadScene("SampleScene 2");
    }
}
