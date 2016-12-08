using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class interactableFlower : VRTK_InteractableObject {

    public override void StartUsing(GameObject usingObject)
    {
        base.StartUsing(usingObject);
        toogleFlower();
    }

    public override void StopUsing(GameObject usingObject)
    {
        base.StopUsing(usingObject);
        toogleFlower();
    }

    protected override void Start()
    {
        base.Start();
    }

    public void toogleFlower()
    {
        
    }

    private IEnumerator turnOff()
    {
            yield return new WaitForSeconds(3f);   
    }
}
