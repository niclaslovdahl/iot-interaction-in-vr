using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class interactableFlower : VRTK_InteractableObject {

    public Material feedback;
    public Material init;
    public GameObject smartwatch;

    public override void StartUsing(GameObject usingObject) {
        base.StartUsing(usingObject);
        feedbackHandler.Instance.index++;
        StartCoroutine(flowerFeedback(feedbackHandler.Instance.index));
    }

    public override void StopUsing(GameObject usingObject) {
        base.StopUsing(usingObject);
        feedbackHandler.Instance.index++;
        StartCoroutine(flowerFeedback(feedbackHandler.Instance.index));
    }

    protected override void Start() {
        base.Start();
    }

    public IEnumerator flowerFeedback(int index) {
        smartwatch.GetComponent<Renderer>().material = feedback;
        yield return new WaitForSeconds(5f);
        if (index == feedbackHandler.Instance.index) {
            smartwatch.GetComponent<Renderer>().material = init;
        }
    }
}
