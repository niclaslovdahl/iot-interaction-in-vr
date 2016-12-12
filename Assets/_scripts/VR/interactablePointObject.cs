using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class interactablePointObject : VRTK_InteractableObject
{

    public GameObject first;
    public GameObject second;
    public GameObject last;

    public override void StartUsing(GameObject usingObject)
    {
        base.StartUsing(usingObject);
        if (first.activeSelf)
        {
            first.SetActive(false);
            second.SetActive(true);
        }
        else if (second.activeSelf)
        {
            second.SetActive(false);
            last.SetActive(true);
        }
        else if (last.activeSelf)
        {
            last.SetActive(false);
        }
    }

    public override void StopUsing(GameObject usingObject)
    {
        base.StopUsing(usingObject);
    }

    protected override void Start()
    {
        base.Start();

    }


}
