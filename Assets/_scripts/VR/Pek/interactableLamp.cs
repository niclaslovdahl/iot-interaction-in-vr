using UnityEngine;
using System.Collections;
using System.Threading;
using VRTK;

/*
 * This class controlls the state of a lamp in the room. Call toogleLamp() to change state.
 * TODO: Implement safe smart watch material change.
 */

public class interactableLamp : VRTK_InteractableObject {
    public Light l1;
    public Light l2;
    public Light l3;
    public Material lampOn;
    public Material lampOff;
    public Material init;
    public GameObject smartwatch;
    public GameObject button;

    private Thread thread;
    private int count = 0;
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

    public bool getLampState() {
        return lampState;
    }

    public void toogleLamp() {
        if (lampState) {
            l1.enabled = false;
            l2.enabled = false;
            l3.enabled = false;
            feedbackHandler.Instance.index++;
            StartCoroutine(turnOff(feedbackHandler.Instance.index));
            lampState = false;
            button.GetComponent<lampButton>().updateButton();
        } else {
            l1.enabled = true;
            l2.enabled = true;
            l3.enabled = true;
            feedbackHandler.Instance.index++;
            StartCoroutine(turnOn(feedbackHandler.Instance.index));
            lampState = true;
            button.GetComponent<lampButton>().updateButton();
        }
    }

    private IEnumerator turnOff(int index) {
        smartwatch.GetComponent<Renderer>().material = lampOff;
        yield return new WaitForSeconds(5f);
        if (index == feedbackHandler.Instance.index) {
            smartwatch.GetComponent<Renderer>().material = init;
        }
    }

    private IEnumerator turnOn(int index) {
        smartwatch.GetComponent<Renderer>().material = lampOn;
        yield return new WaitForSeconds(5f);
        if (index == feedbackHandler.Instance.index) {
            smartwatch.GetComponent<Renderer>().material = init;
        }

    }
}