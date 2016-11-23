using UnityEngine;
using System.Collections;

public class KeyController : MonoBehaviour {

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
            
        }


    }

    // Use this for initialization
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {

    }
}
