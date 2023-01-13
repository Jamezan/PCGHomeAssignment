using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider collider = this.gameObject.AddComponent<BoxCollider>();
        collider.GetComponent<BoxCollider>().enabled = false;
        collider.center = new Vector3(270f, -4.5f, 58.5f);
        collider.size = new Vector3(28f, 10f, 17f);
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")) {
            Debug.Log("GameOver");
            Application.Quit();
        }
    }

}
