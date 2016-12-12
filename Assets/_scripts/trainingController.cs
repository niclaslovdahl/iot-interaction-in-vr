using UnityEngine;
using System.Collections;
using VRTK;
using UnityEngine.SceneManagement;

/*
 * This class handles all key events in the scene.
 */

public class trainingController : MonoBehaviour
{

    public GameObject leftController;
    public GameObject rightController;
    public GameObject sphere;

    private AsyncOperation scene;

    private void Start()
    {
        scene = SceneManager.LoadSceneAsync("Main", LoadSceneMode.Single);
        scene.allowSceneActivation = false;
    }

    public IEnumerator loadLevel()
    {
        iTween.FadeTo(sphere, 1f, 5f);
        yield return new WaitForSeconds(5f);
        scene.allowSceneActivation = true;
    }

    public IEnumerator resetLevel()
    {
        iTween.FadeTo(sphere, 1f, 2f);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Start");
    }

    void OnGUI()
    {
        Event e = Event.current;

        /* Code used to detect what key was pressed 
		if (e.isKey) {
			Debug.Log ("Detected key code: " + e.keyCode);
		}
		*/

        if (e.Equals(Event.KeyboardEvent(KeyCode.Return.ToString())))
        {
            StartCoroutine(loadLevel());
        }
        else if (e.Equals(Event.KeyboardEvent(KeyCode.Backspace.ToString())))
        {
            StartCoroutine(resetLevel());
        }
        else if (e.Equals(Event.KeyboardEvent(KeyCode.Keypad3.ToString())))
        {

        }
        else if (e.Equals(Event.KeyboardEvent(KeyCode.Keypad4.ToString())))
        {

        }
        else if (e.Equals(Event.KeyboardEvent(KeyCode.Keypad5.ToString())))
        {

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
