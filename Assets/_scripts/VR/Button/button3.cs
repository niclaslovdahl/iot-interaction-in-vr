using UnityEngine;
using System.Collections;

public class button3 : MonoBehaviour {

    public GameObject controller;
    private discoverDevices rightControllerScript;

    public Light l1;
    public Light l2;
    public Light l3;

    public Material pressed;
    public Material button;
    private MeshRenderer mesh;

    private AudioSource audio;

    int timer = 50;
    bool countdown = false;

    void OnTriggerEnter(Collider other) {
        Debug.Log("button pressed");
        countdown = true;
        //rightControllerScript.vibrate(1000);
        audio.Play();
    }

    void OnTriggerExit(Collider other) {
        timer = 50;
    }

    // Use this for initialization
    void Start() {
        mesh = GetComponent<MeshRenderer>();
        mesh.material = button;
        rightControllerScript = controller.GetComponent(typeof(discoverDevices)) as discoverDevices;
        audio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void FixedUpdate() {
        if (countdown) {
            timer--;
        }

        if (timer < 0) {
            countdown = false;
            timer = 50;
            if (l1.enabled) {
                l1.enabled = false;
                l2.enabled = false;
                l3.enabled = false;
                mesh.material = pressed;
            } else {
              l1.enabled = true;
              l2.enabled = true;
              l3.enabled = true;
              mesh.material = button;
            }
        }
    }
}
