using UnityEngine;
using VRTK;

/// <summary>
/// 
/// </summary>

public class interactableTV : VRTK_InteractableObject {

    public GameObject TVmenu;
    private GameObject movie;

    public override void StartUsing(GameObject usingObject) {
        base.StartUsing(usingObject);
        movie.GetComponent<playMovie>().toggleTv();
    }

    public override void StopUsing(GameObject usingObject) {
        base.StopUsing(usingObject);
        movie.GetComponent<playMovie>().toggleTv();
    }

    protected override void Start() {
        base.Start();
        movie = GameObject.FindGameObjectWithTag("movie");
    }


}