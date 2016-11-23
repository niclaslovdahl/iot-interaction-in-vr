using UnityEngine;
using System.Collections;
//
//	1) In your scene you should have controllers attached to the camera rig, eg:
//	[CameraRig]
//	-- Controller (Left)
//
//	2) Ensure that controller has both a "SteamVR_TrackedObject" script AND "SteamVR_TrackedController" script
//
//	3) Add this script to the controller, and modify it as necessary
//
[RequireComponent(typeof(SteamVR_TrackedController))]
public class ControllerManagerLeft : MonoBehaviour {

    private Animator anim;
    int Idle = Animator.StringToHash("Idle");
    int Point = Animator.StringToHash("Point");
    int MiddleFinger = Animator.StringToHash("MiddleFinger");

    void Start() {
        anim = GameObject.FindGameObjectWithTag("leftHand").GetComponent<Animator>();
    }

    // Use this for initialization
    void OnEnable() {
        SteamVR_TrackedController controller = GetComponent<SteamVR_TrackedController>();
        controller.TriggerClicked += OnClickTrigger;
        controller.TriggerUnclicked += OnUnclickTrigger;
        controller.PadClicked += OnPadClicked;
        controller.PadUnclicked += OnUnclickPad;
    }

    void OnDisable() {
        SteamVR_TrackedController controller = GetComponent<SteamVR_TrackedController>();
        controller.TriggerClicked -= OnClickTrigger;
        controller.TriggerUnclicked -= OnUnclickTrigger;
        controller.PadClicked -= OnPadClicked;
        controller.PadUnclicked -= OnUnclickPad;
    }

    void OnPadClicked(object sender, ClickedEventArgs e) {
        anim.SetTrigger(Point);
    }

    void OnUnclickPad(object sender, ClickedEventArgs e) {
        anim.SetTrigger(Idle);
    }

    void OnClickTrigger(object sender, ClickedEventArgs e) {
        anim.SetTrigger(MiddleFinger);
    }

    void OnUnclickTrigger(object sender, ClickedEventArgs e) {
        anim.SetTrigger(Idle);
    }

}