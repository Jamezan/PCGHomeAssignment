using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSpawner : MonoBehaviour
{

    void Start() {
        
        checkScene();
    }

    void checkScene() {
        Scene lvlOneScene = SceneManager.GetSceneByName("Level1");
        if(lvlOneScene.isLoaded) {
            this.transform.localPosition = new Vector3(Random.Range(-20f, 200f), -5f, 5f);
            BoxCollider collider = this.gameObject.AddComponent<BoxCollider>();
            collider.center = new Vector3(-0.0615486205f, 0.938666821f, -0.184310913f);
            collider.size = new Vector3(2.05545592f, 1.43860245f, 6.06918621f);
            collider.isTrigger = true;
        }
        else {
            this.transform.localPosition = new Vector3(35f, 0f, Random.Range(60f, -40f));
            BoxCollider collider = this.gameObject.AddComponent<BoxCollider>();
            collider.center = new Vector3(-0.0615486205f, 0.938666821f, -0.184310913f);
            collider.size = new Vector3(2.05545592f, 1.43860245f, 6.06918621f);
            collider.isTrigger = true;
        }
    }
}
