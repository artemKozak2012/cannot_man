using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class test2 : MonoBehaviour
{
    public Scene scene;

    public void reloadscene()
    {
        SceneManager.LoadScene("scene");
    }


}
