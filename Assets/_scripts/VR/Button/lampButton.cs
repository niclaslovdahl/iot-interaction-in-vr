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
        Debug.Log(other.gameObject.name);
        if (other.tag == "leftTrigger" || other.tag == "rightTrigger")
        {
            lamp.GetComponent<interactableLamp>().toogleLamp();
            click.Play();
            Debug.Log("button pressed");
            if (lamp.GetComponent<interactableLamp>().getLampState())
            {
                mesh.material = buttonOn;
            }
            else
            {
                mesh.material = buttonOff;
            }
            //rightControllerScript.vibrate(1000);
            //audio.Play();
        }


    }

    void OnTriggerExit(Collider other)
    {

    }


    // Use this for initialization
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        click = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
