using UnityEngine;
using VRTK;

public class Ball : VRTK_InteractableObject
{
    public Material red;
    public Material blue;

    private MeshRenderer rend;

    public override void StartUsing(GameObject usingObject)
    {
        base.StartUsing(usingObject);
        if (rend != null)
        {
            rend.material = red;
        }
    }

    public override void StopUsing(GameObject usingObject)
    {
        base.StopUsing(usingObject);
        if (rend != null)
        {
            rend.material = blue;
        }
    }

    protected override void Start()
    {
        base.Start();
        rend = GetComponent<MeshRenderer>();
    }


}