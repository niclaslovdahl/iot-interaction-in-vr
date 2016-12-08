using UnityEngine;
using System.Collections;
using VRTK;

/*
 * This class handles all key events in the scene.
 */

public class KeyController : MonoBehaviour
{

    public GameObject lamp1;
    public GameObject lamp2;
    public GameObject lamp3;
    public GameObject lamp4;
    public GameObject movie;
    public GameObject leftController;
    public GameObject rightController;

    void OnGUI()
    {
        Event e = Event.current;

        /* Code used to detect what key was pressed 
		if (e.isKey) {
			Debug.Log ("Detected key code: " + e.keyCode);
		}
		*/

        if (e.Equals(Event.KeyboardEvent(KeyCode.Keypad1.ToString())))
        {
            lamp1.GetComponent<interactableLamp>().toogleLamp();
        }
        else if (e.Equals(Event.KeyboardEvent(KeyCode.Keypad2.ToString())))
        {
            lamp2.GetComponent<interactableLamp>().toogleLamp();
        }
        else if (e.Equals(Event.KeyboardEvent(KeyCode.Keypad3.ToString())))
        {
            lamp3.GetComponent<interactableLamp>().toogleLamp();
        }
        else if (e.Equals(Event.KeyboardEvent(KeyCode.Keypad4.ToString())))
        {
            lamp4.GetComponent<interactableLamp>().toogleLamp();
        }
        else if (e.Equals(Event.KeyboardEvent(KeyCode.Keypad5.ToString())))
        {
            movie.GetComponent<playMovie>().toggleTv();
        }
        else if (e.Equals(Event.KeyboardEvent(KeyCode.Alpha1.ToString())))
        {
            if (leftController.GetComponent<VRTK_SimplePointer>().pointerHitColor.a == 0)
            {
                leftController.GetComponent<VRTK_SimplePointer>().pointerHitColor = new Color(0f, 0.5f, 0f, 0.3f);
                rightController.GetComponent<VRTK_SimplePointer>().pointerHitColor = new Color(0f, 0.5f, 0f, 0.3f);

            }
            else
            {
                leftController.GetComponent<VRTK_SimplePointer>().pointerHitColor = new Color(0f, 0.5f, 0f, 0f);
                rightController.GetComponent<VRTK_SimplePointer>().pointerHitColor = new Color(0f, 0.5f, 0f, 0f);
            }


        }

    }
}
