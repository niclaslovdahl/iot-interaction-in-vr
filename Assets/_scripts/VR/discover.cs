using UnityEngine;
using System.Collections;

public class discover : MonoBehaviour {

    private Transform trans;
    private GameObject[] spheres;
    private bool activate;


    // Use this for initialization
    void Start () {
  
        trans = GetComponent<Transform>();
        spheres = GameObject.FindGameObjectsWithTag("sphere");

    }

	
	// Update is called once per frame
	void Update () {
        if ((trans.position.y > 2))
        {


            foreach (GameObject sphere in spheres)
            {
                sphere.GetComponent<MeshRenderer>().enabled = true;
            }
           

        }
        if((trans.position.y <= 2))
        {

            foreach (GameObject sphere in spheres)
            {
                sphere.GetComponent<MeshRenderer>().enabled = false;
            }

        }
	}
}
