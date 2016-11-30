using UnityEngine;
using VRTK;

/*
 * This class controlls the state of a lamp in the room. Call toogleLamp() to change state.
 */

public class interactableLamp : VRTK_InteractableObject {
    public Light l1;
    public Light l2;
    public Light l3;

    private bool lampState = true;

    public override void StartUsing(GameObject usingObject) {
        base.StartUsing(usingObject);
        toogleLamp();
    }

    public override void StopUsing(GameObject usingObject) {
        base.StopUsing(usingObject);
        toogleLamp();
    }

    protected override void Start() {
        base.Start();
    }

    public void toogleLamp() {
        if (lampState) {
            l1.enabled = false;
            l2.enabled = false;
            l3.enabled = false;
            lampState = false;
        } else {
            l1.enabled = true;
            l2.enabled = true;
            l3.enabled = true;
            lampState = true;
        }
    }
}