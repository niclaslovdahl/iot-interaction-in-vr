using UnityEngine;
using System.Collections;

/// <summary>
/// This class keeps track of gesture (hands up).
/// This script should be dropped on the HTC Vive controllers.
/// </summary>

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class discoverDevices : MonoBehaviour
{

    private Transform trans;
    private bool activated;
    private GameObject[] discover;
    private GameObject obj;

    public Transform head;

    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();

    }

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

        device = SteamVR_Controller.Input((int)trackedObj.index);

        if ((trans.position.y > head.position.y + 0.15f) && (activated == false))
        {
            Debug.Log("Active discover state");

            foreach (GameObject go in discover)
            {
                go.GetComponent<discoverLamp>().active();
            }
            activated = true;

        }
        if ((trans.position.y <= head.position.y + 0.15f) && (activated == true))
        {
            Debug.Log("Inactive discover state");

            foreach (GameObject go in discover)
            {
                go.GetComponent<discoverLamp>().inactive();
            }
            activated = false;
        }
    }

    public void vibrate(ushort durationTime)
    {
        device.TriggerHapticPulse(durationTime);
    }
}
