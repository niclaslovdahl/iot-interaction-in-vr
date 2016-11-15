using UnityEngine;
using System.Collections;

public class keyEventDetection : MonoBehaviour
{

    public Light dlight;
    public GameObject obj1;
    public GameObject obj2;

    void OnGUI()
    {
        Event e = Event.current;

        /* Code used to detect what key was pressed
		if (e.isKey) {
			Debug.Log ("Detected key code: " + e.keyCode);
		}
		*/

        if (e.Equals(Event.KeyboardEvent(KeyCode.Alpha1.ToString())))
        {
            dlight.enabled = !dlight.enabled;
        }
        else if (e.Equals(Event.KeyboardEvent(KeyCode.Alpha2.ToString())))
        {
            obj1.SetActive(!obj1.activeSelf);
        }
        else if (e.Equals(Event.KeyboardEvent(KeyCode.Alpha3.ToString())))
        {
            obj2.SetActive(!obj2.activeSelf);
        }


    }

    // Use this for initialization
    void Start()
    {
        dlight = this.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
