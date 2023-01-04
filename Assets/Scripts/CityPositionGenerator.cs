using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityPositionGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int numberChosen = Random.Range(1,4);
        if(numberChosen == 1) {
            Debug.Log("1");
            this.transform.localPosition = new Vector3(200f, 0, 0);
        }
        else if(numberChosen == 2) {
            Debug.Log("2");
            this.transform.localPosition = new Vector3(0 ,0 ,200f);
        }
        else if(numberChosen == 3) {
            Debug.Log("3");
            this.transform.localPosition = new Vector3(-200f, 0, 0);
        }
        else if(numberChosen == 4) {
            Debug.Log("4");
            this.transform.localPosition = new Vector3(0, 0, -200f);
        }
    }
}
