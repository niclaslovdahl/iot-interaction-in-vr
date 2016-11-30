using UnityEngine;
using System.Collections;

/*
 * This class handles all key events in the scene.
 */

public class KeyController : MonoBehaviour {

    public GameObject lamp1;
    public GameObject lamp2;
    public GameObject lamp3;
    public GameObject lamp4;
    public GameObject movie;

    void OnGUI() {
        Event e = Event.current;

        /* Code used to detect what key was pressed 
		if (e.isKey) {
			Debug.Log ("Detected key code: " + e.keyCode);
		}
		*/

        if (e.Equals(Event.KeyboardEvent(KeyCode.Keypad1.ToString()))) {
            lamp1.GetComponent<interactableLamp>().toogleLamp();
        } else if (e.Equals(Event.KeyboardEvent(KeyCode.Keypad2.ToString()))) {
            lamp2.GetComponent<interactableLamp>().toogleLamp();
        } else if (e.Equals(Event.KeyboardEvent(KeyCode.Keypad3.ToString()))) {
            lamp3.GetComponent<interactableLamp>().toogleLamp();
        } else if (e.Equals(Event.KeyboardEvent(KeyCode.Keypad4.ToString()))) {
            lamp4.GetComponent<interactableLamp>().toogleLamp();
        } else if (e.Equals(Event.KeyboardEvent(KeyCode.Keypad5.ToString()))) {
            movie.GetComponent<playMovie>().toggleTv();
        }
    }
}
