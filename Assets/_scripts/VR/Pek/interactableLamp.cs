using UnityEngine;
using System.Collections;
using System.Threading;
using VRTK;

/*
 * This class controlls the state of a lamp in the room. Call toogleLamp() to change state.
 * TODO: Implement safe smart watch material change.
 */

public class interactableLamp : VRTK_InteractableObject
{
    public Light l1;
    public Light l2;
    public Light l3;
    public Material lampOn;
    public Material lampOff;
    public Material black;
    public GameObject smartwatch;

    private Thread thread;
    private int count = 0;
    private bool lampState = true;

    public override void StartUsing(GameObject usingObject)
    {
        base.StartUsing(usingObject);
        toogleLamp();
    }

    public override void StopUsing(GameObject usingObject)
    {
        base.StopUsing(usingObject);
        toogleLamp();
    }

    protected override void Start()
    {
        base.Start();
    }

    public bool getLampState()
    {
        return lampState;
    }

    public void toogleLamp()
    {
        if (lampState)
        {
            l1.enabled = false;
            l2.enabled = false;
            l3.enabled = false;
            StartCoroutine(turnOff());
            lampState = false;
        }
        else
        {
            l1.enabled = true;
            l2.enabled = true;
            l3.enabled = true;
            StartCoroutine(turnOn());
            lampState = true;
        }
    }

    private IEnumerator turnOff()
    {
        count++;
        smartwatch.GetComponent<Renderer>().material = lampOff;
        yield return new WaitForSeconds(2f);
        if (count == 1)
        {
            smartwatch.GetComponent<Renderer>().material = black;
        }
        count--;
    }

    private IEnumerator turnOn()
    {
        count++;
        smartwatch.GetComponent<Renderer>().material = lampOn;
        yield return new WaitForSeconds(2f);
        smartwatch.GetComponent<Renderer>().material = black;
        if (count == 1)
        {
            smartwatch.GetComponent<Renderer>().material = black;
        }
        count--;
    }
}