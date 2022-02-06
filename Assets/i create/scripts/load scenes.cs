using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    
  public void reloadscene()
    {
        SceneManager.LoadScene("SampleScene");  
    }

    
    public void reloadscene2()
    {
        SceneManager.LoadScene("SampleScene 2");
    }
}
