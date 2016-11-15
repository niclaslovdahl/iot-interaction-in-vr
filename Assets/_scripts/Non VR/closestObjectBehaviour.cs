using UnityEngine;
using System.Collections;

public class closestObjectBehaviour : MonoBehaviour
{

    public Material red;
    public Material blue;

    private MeshRenderer mr;

    // Use this for initialization
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }

    public void active()
    {
        mr.material = red;
    }

    public void inactive()
    {
        mr.material = blue;
    }
}
