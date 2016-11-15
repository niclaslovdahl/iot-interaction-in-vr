using UnityEngine;
using System.Collections;

public class tv_script : MonoBehaviour {

    public GameObject lamp;
    int timer = 400;

    // Use this for initialization
    void Start () {
        lamp = GameObject.Find("Lamp");
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (timer > 0)
        {
            timer--;
        }
        else {
            lamp.SetActive(false);
        }
	
	}
}
