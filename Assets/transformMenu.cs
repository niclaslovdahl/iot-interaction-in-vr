using UnityEngine;
using System.Collections;

public class transformMenu : MonoBehaviour {

    public Transform trans;

    // Use this for initialization
    void Start() {
        transform.position = trans.position;
        transform.rotation = trans.rotation;
    }

    // Update is called once per frame
    void Update() {
        transform.position = new Vector3(trans.position.x, trans.position.y + 0.1f, trans.position.z);

        transform.rotation = Quaternion.Euler(trans.rotation.x, trans.rotation.y, trans.rotation.z);
        //setTransform();
    }

    void setTransform() {
        // transform.position = new Vector3(trans.position.x, trans.position.y, trans.position.z);
        // transform.rotation = new Vector3(trans.rotation.x, trans.rotation.y, trans.rotation.z);
    }
}
