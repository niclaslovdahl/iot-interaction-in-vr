using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampButton : MonoBehaviour
{

    public GameObject lamp;
    public Material buttonOn;
    public Material buttonOff;
    public Material buttonOnTrigger;

    private MeshRenderer mesh;
    private AudioSource click;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "leftTrigger" || other.tag == "rightTrigger")
        {
            lamp.GetComponent<interactableLamp>().toogleLamp();
            click.Play();
            if (other.tag == "rightTrigger")
            {
                GameObject.FindGameObjectWithTag("rightController").GetComponent<discoverDevices>().vibrate(2000);
            }
            else
            {
                GameObject.FindGameObjectWithTag("leftController").GetComponent<discoverDevices>().vibrate(2000);
            }
            updateButton();
        }
    }

    void OnTriggerExit(Collider other)
    {

    }

    public void updateButton()
    {
        if (lamp.GetComponent<interactableLamp>().getLampState())
        {
            mesh.material = buttonOn;
        }
        else
        {
            mesh.material = buttonOff;
        }
    }

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        click = GetComponent<AudioSource>();
    }
}
