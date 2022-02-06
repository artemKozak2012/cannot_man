using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class klavishas : MonoBehaviour
{
    public Transform teleport;
    public Transform teleport1;
    public int score;
    public Text ScoreText;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.position = teleport.position;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            transform.position = teleport1.position;
        } 
        if (score == 3 )
        {
            score = 0;
            ScoreText.text = $"{score}";   
        }
    }
}
