using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider collider = this.gameObject.AddComponent<BoxCollider>();
        collider.GetComponent<BoxCollider>().enabled = false;
        collider.center = new Vector3(198.61615f, -4.64669371f, 9.61674023f);
        collider.size = new Vector3(14.6064301f, 10.2933874f, 14.4142361f);
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player")) {
            SceneManager.LoadScene("Level2");
        }
    }

}
