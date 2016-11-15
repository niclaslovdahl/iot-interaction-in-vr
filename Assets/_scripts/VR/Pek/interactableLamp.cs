using UnityEngine;
using VRTK;

/// <summary>
/// 
/// </summary>

public class interactableLamp : VRTK_InteractableObject
{
    public Light l1;
    public Light l2;
    public Light l3;

    public override void StartUsing(GameObject usingObject)
    {
        base.StartUsing(usingObject);
		l1.enabled = false;
		l2.enabled = false;
        l3.enabled = false;
    }

    public override void StopUsing(GameObject usingObject)
    {
        base.StopUsing(usingObject);
        l1.enabled = true;
		l2.enabled = true;
		l3.enabled = true;
    }

    protected override void Start()
    {
        base.Start();
    }


}