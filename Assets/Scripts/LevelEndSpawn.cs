using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEndSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider collider = this.gameObject.AddComponent<BoxCollider>();
        collider.center = new Vector3(-20.1719017f, -4.94830608f, -81.015625f);
        collider.size = new Vector3(20.6951504f, 10.8966103f, 18.5820313f);
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
