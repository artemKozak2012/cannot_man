using Cinemachine;
using UnityEngine;

public class SetFollow : MonoBehaviour
{

    public CinemachineVirtualCamera virtCam;

    private void Awake()
    {
        GameManager.PlayerCreated += OnPlayerCreated;

    }

    private void OnPlayerCreated()
    {
        var player = GameObject.FindGameObjectWithTag("Player");
        virtCam.Follow = player.transform;
    }

    private void OnDestroy()
    {
        GameManager.PlayerCreated -= OnPlayerCreated;
    }
}
