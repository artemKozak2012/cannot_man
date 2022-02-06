using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class FullScreenBtn : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(ChangeFullScreen);
    }

    private void OnDestroy()
    {
        button.onClick.RemoveListener(ChangeFullScreen);
    }

    private void ChangeFullScreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
