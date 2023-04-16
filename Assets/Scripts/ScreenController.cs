using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenController : MonoBehaviour
{
    void Start()
    {
        string doorType = PlayerPrefs.GetString("doorType", "Elevator");
        SpawnManager.instance.SetSpawnPoint(doorType);
    }
}
