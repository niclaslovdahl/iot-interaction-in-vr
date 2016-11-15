using UnityEngine;
using System.Collections;

public class discoverBall2 : MonoBehaviour {

	private MeshRenderer mesh;
	private Transform trans;
	private bool activated;
	private GameObject[] spheres;

	public Material red;
	public Material blue;
	public Transform head;
	GameObject obj;

	// Use this for initialization
	void Start() {
		mesh = GetComponent<MeshRenderer>();
		trans = GetComponent<Transform>();
		mesh.material = blue;
		spheres = GameObject.FindGameObjectsWithTag("sphere");
		obj = GameObject.FindGameObjectWithTag ("head");
		head = obj.GetComponent<Transform> ();
	}


	// Update is called once per frame
	void Update() {
		if ((trans.position.y > head.position.y) && (mesh.sharedMaterial != red)) {
			Debug.Log("Changed color to red and summon spheres");
			mesh.material = red;

			foreach (GameObject sphere in spheres) {
				sphere.GetComponent<MeshRenderer>().enabled = true;
			}

		}
		if ((trans.position.y <= head.position.y) && (mesh.sharedMaterial != blue)) {
			Debug.Log("Changed color to blue and remove spheres");
			mesh.material = blue;

			foreach (GameObject sphere in spheres) {
				sphere.GetComponent<MeshRenderer>().enabled = false;
			}

		}
	}
}
