using UnityEngine;
using System.Collections;

public class temp_color : MonoBehaviour {
    public Material red;

    // Use this for initialization
    void Start () {
        MeshRenderer rend = GetComponent<MeshRenderer>();
        rend.material = red;
        Debug.Log("hej");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
