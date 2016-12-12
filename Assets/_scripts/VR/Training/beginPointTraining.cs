using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beginPointTraining : MonoBehaviour
{

    public GameObject sphere1;
    public GameObject sphere2;
    public GameObject sphere3;
    public GameObject sphere4;
    public GameObject cube;

    private bool breakPoint = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (sphere1.GetComponent<interactableSphere>().getSphereState() && sphere1.GetComponent<interactableSphere>().getSphereState() && sphere3.GetComponent<interactableSphere>().getSphereState() && sphere4.GetComponent<interactableSphere>().getSphereState() && breakPoint)
        {
            cube.SetActive(true);
            breakPoint = false;
        }
    }
}
