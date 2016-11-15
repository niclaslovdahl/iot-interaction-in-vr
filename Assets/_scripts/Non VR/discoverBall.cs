using UnityEngine;
using System.Collections;

public class discoverBall : MonoBehaviour {

    private MeshRenderer mesh;
    private Transform trans;
    private bool activated;
    private GameObject[] spheres;

    public Material red;
    public Material blue;

    // Use this for initialization
    void Start() {
        mesh = GetComponent<MeshRenderer>();
        trans = GetComponent<Transform>();
        mesh.material = blue;
        spheres = GameObject.FindGameObjectsWithTag("sphere");

    }


    // Update is called once per frame
    void Update() {
        if ((trans.position.y > 2) && (mesh.sharedMaterial != red)) {
            Debug.Log("Changed color to red");
            mesh.material = red;

            foreach (GameObject sphere in spheres) {
                sphere.GetComponent<MeshRenderer>().enabled = true;
            }

        }
        if ((trans.position.y <= 2) && (mesh.sharedMaterial != blue)) {
            Debug.Log("Changed color to blue");
            mesh.material = blue;

            foreach (GameObject sphere in spheres) {
                sphere.GetComponent<MeshRenderer>().enabled = false;
            }

        }
    }
}
