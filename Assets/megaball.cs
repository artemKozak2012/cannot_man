using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class megaball : MonoBehaviour
{
    public Transform teleport;
    public GameObject ball;

public void teleportball()
    {
        ball.transform.position = teleport.transform.position;
    }

}
