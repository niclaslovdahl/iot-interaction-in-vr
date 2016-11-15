using UnityEngine;
using System.Collections;

/// <summary>
/// This class handles GameObjects with lights for discover device.
/// </summary>

public class discoverLamp : discoverable
{
    private GameObject[] lamps;

    // Init
    public override void Start()
    {
        lamps = GameObject.FindGameObjectsWithTag("lampLights");
    }
    // Discovered state active
    public override void active()
    {
        foreach (GameObject lamp in lamps)
        {
            lamp.GetComponent<Light>().enabled = true;
        }
    }
    // Discovered state inactive
    public override void inactive()
    {
        foreach (GameObject lamp in lamps)
        {
            lamp.GetComponent<Light>().enabled = false;
        }
    }


}
