using UnityEngine;
using System.Collections;

public class KeyController : MonoBehaviour {

    public GameObject lamp1up;
    public GameObject lamp1horizontal;
    public GameObject lamp1down;
    public GameObject lamp2up;
    public GameObject lamp2horizontal;
    public GameObject lamp2down;
    public GameObject lamp3up;
    public GameObject lamp3horizontal;
    public GameObject lamp3down;
    public GameObject lamp4up;
    public GameObject lamp4horizontal;
    public GameObject lamp4down;
    public GameObject movie;

    void OnGUI() {
        Event e = Event.current;

        /* Code used to detect what key was pressed 
		if (e.isKey) {
			Debug.Log ("Detected key code: " + e.keyCode);
		}
		*/

        if (e.Equals(Event.KeyboardEvent(KeyCode.Keypad1.ToString()))) {

        } else if (e.Equals(Event.KeyboardEvent(KeyCode.Keypad2.ToString()))) {

        } else if (e.Equals(Event.KeyboardEvent(KeyCode.Keypad3.ToString()))) {

        } else if (e.Equals(Event.KeyboardEvent(KeyCode.Keypad4.ToString()))) {

        } else if (e.Equals(Event.KeyboardEvent(KeyCode.Keypad5.ToString()))) {
            movie.GetComponent<playMovie>().toggleTv();
        }


    }
}
