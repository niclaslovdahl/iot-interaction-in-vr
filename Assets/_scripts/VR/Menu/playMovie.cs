using UnityEngine;
using System.Collections;

public class playMovie : MonoBehaviour
{
    private MeshRenderer mesh;
    private Renderer render;
    private MovieTexture movie;
    private AudioSource audio;

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

            mesh.enabled = !mesh.enabled;
            if (mesh.enabled == true)
            {
                movie.Play();
                audio.Play();
            }
            else
            {
                movie.Stop();
                audio.Stop();
            }

        }
        else if (e.Equals(Event.KeyboardEvent(KeyCode.Alpha2.ToString())))
        {

        }
        else if (e.Equals(Event.KeyboardEvent(KeyCode.Alpha3.ToString())))
        {

        }


    }

    public void startMovie()
    {
        movie.Play();
        audio.Play();
    }

    public void stopMovie()
    {
        movie.Stop();
        audio.Stop();
    }

    // Use this for initialization
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        render = GetComponent<Renderer>();
        movie = (MovieTexture)render.material.mainTexture;
        audio = GetComponent<AudioSource>();
    }
}
