using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;

    void Start() {
        Instantiate(playerPrefab, new Vector3(0,0,0), Quaternion.identity);
    }
}
