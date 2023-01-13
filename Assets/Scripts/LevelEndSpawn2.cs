using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEndSpawn2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider collider = this.gameObject.AddComponent<BoxCollider>();
        collider.center = new Vector3(244f, -4.5f, -65f);
        collider.size = new Vector3(15f, 11f, 25f);
        collider.isTrigger = true;
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")) {
            BoxCollider levelEnd = GameObject.Find("LevelEndCollider").GetComponent<BoxCollider>();
            levelEnd.GetComponent<BoxCollider>().enabled = true;
            levelEnd.isTrigger = true;
        }
    }
}
