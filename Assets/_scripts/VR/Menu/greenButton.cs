using UnityEngine;
using System.Collections;

public class greenButton : MonoBehaviour {

    private GameObject movie;

    void OnTriggerEnter(Collider other) {
        Debug.Log("trigger entered");
        movie.GetComponent<playMovie>().startMovie();
        movie.GetComponent<MeshRenderer>().enabled = true;
        transform.parent.gameObject.SetActive(false);
    }

    void OnTriggerExit(Collider other) {

    }

    // Use this for initialization
    void Start() {
        movie = GameObject.FindGameObjectWithTag("movie");
    }

    // Update is called once per frame
    void Update() {

    }
}
