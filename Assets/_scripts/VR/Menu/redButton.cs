using UnityEngine;
using System.Collections;

public class redButton : MonoBehaviour
{

    private GameObject movie;

    void OnTriggerEnter(Collider other)
    {
        movie.GetComponent<playMovie>().stopMovie();
        movie.GetComponent<MeshRenderer>().enabled = false;
        transform.parent.gameObject.SetActive(false);

    }

    void OnTriggerExit(Collider other)
    {

    }

    // Use this for initialization
    void Start()
    {
        movie = GameObject.FindGameObjectWithTag("movie");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
