using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EatController : MonoBehaviour
{
    public Text ScoreText;
    public int score;

     void Update ()
    {
        {
            score++;
            ScoreText.text = $"{score}";
        }
    }
}