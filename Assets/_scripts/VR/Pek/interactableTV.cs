using UnityEngine;
using VRTK;

/// <summary>
/// 
/// </summary>

public class interactableTV : VRTK_InteractableObject {

    public GameObject TVmenu;

    public override void StartUsing(GameObject usingObject) {
        base.StartUsing(usingObject);
        TVmenu.SetActive(true);
        Debug.Log("tv active");
    }

    public override void StopUsing(GameObject usingObject) {
        base.StopUsing(usingObject);
        TVmenu.SetActive(true);
    }

    protected override void Start() {
        base.Start();
    }


}