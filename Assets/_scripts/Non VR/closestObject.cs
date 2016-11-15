using UnityEngine;
using System.Collections;

public class closestObject : MonoBehaviour
{

    public Material blue;
    public Material red;

    private GameObject current;
    private GameObject temp;

    // Use this for initialization
    void Start()
    {
        current = FindClosestObject();
        current.GetComponent<MeshRenderer>().material = red;
    }

    // Update is called once per frame
    void Update()
    {
        temp = FindClosestObject();
        if (!temp.GetHashCode().Equals(current.GetHashCode()))
        {
            current.GetComponent<closestObjectBehaviour>().inactive();
            current = temp;
            current.GetComponent<closestObjectBehaviour>().active();
        }


    }


    GameObject FindClosestObject()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("tracked");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }
}
