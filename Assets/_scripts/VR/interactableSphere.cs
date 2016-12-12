using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactableSphere : MonoBehaviour
{

    public GameObject button;
    public Material red;
    public Material green;

    private bool sphereState = false;
    private MeshRenderer mesh;

    // Use this for initialization
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mesh.material = red;
    }

    public bool getSphereState()
    {
        return sphereState;
    }

    public void toogleSphere()
    {
        if (sphereState)
        {
            mesh.material = red;
            sphereState = false;
            button.GetComponent<lampButtonTraining>().updateButton();
        }
        else
        {
            mesh.material = green;
            sphereState = true;
            button.GetComponent<lampButtonTraining>().updateButton();
        }
    }
}
