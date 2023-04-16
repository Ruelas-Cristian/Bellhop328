using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager instance;
    public Transform elevatorSpawnPoint;
    public Transform roomSpawnPoint;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    public void SetSpawnPoint(string door)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player == null) return;

        if (door == "Elevator")
        {
            player.transform.position = elevatorSpawnPoint.position;
        }
        else if (door == "Room")
        {
            player.transform.position = roomSpawnPoint.position;
        }
    }
}