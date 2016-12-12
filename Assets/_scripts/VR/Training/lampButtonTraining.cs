using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampButtonTraining : MonoBehaviour
{

    public GameObject sphere;
    public Material buttonOn;
    public Material buttonOff;
    public Material buttonOnTrigger;

    private MeshRenderer mesh;
    private AudioSource click;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.tag == "leftTrigger" || other.tag == "rightTrigger")
        {
            sphere.GetComponent<interactableSphere>().toogleSphere();
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
        if (sphere.GetComponent<interactableSphere>().getSphereState())
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
