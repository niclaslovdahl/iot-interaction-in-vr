using UnityEngine;
using System.Collections;

/// <summary>
/// This class keeps track of gesture (hands up).
/// This script should be dropped on the HTC Vive controllers.
/// </summary>

public class discoverDevices : MonoBehaviour
{

    private Transform trans;
    private bool activated;
    private GameObject[] discover;
    private GameObject obj;

    public Transform head;


    // Init
    void Start()
    {
        trans = GetComponent<Transform>();
        discover = GameObject.FindGameObjectsWithTag("discover");
    }


    // Update is called once per frame
    // Function tracks if gesture (hands up) is active och inactive.
    void Update()
    {
        if ((trans.position.y > head.position.y) && (activated == false))
        {
            Debug.Log("Active discover state");

            foreach (GameObject go in discover)
            {
                go.GetComponent<discoverLamp>().active();
            }
            activated = true;

        }
        if ((trans.position.y <= head.position.y) && (activated == true))
        {
            Debug.Log("Inactive discover state");

            foreach (GameObject go in discover)
            {
                go.GetComponent<discoverLamp>().inactive();
            }
            activated = false;
        }
    }
}
