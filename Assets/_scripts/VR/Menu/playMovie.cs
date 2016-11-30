using UnityEngine;
using System.Collections;

/*
 * This class handles the state of the movie played on the TV. Call toggleTV() to change state.
 */

public class playMovie : MonoBehaviour {
    private MeshRenderer mesh;
    private Renderer render;
    private MovieTexture movie;
    private AudioSource audio;
    public bool movieState = false;

    public void toggleTv() {
        if (movieState) {
            stopMovie();
        } else {
            startMovie();
        }
    }

    private void startMovie() {
        mesh.enabled = !mesh.enabled;
        movie.Play();
        audio.Play();
        movieState = true;
    }

    private void stopMovie() {
        mesh.enabled = !mesh.enabled;
        movie.Stop();
        audio.Stop();
        movieState = false;
    }

    void Start() {
        mesh = GetComponent<MeshRenderer>();
        render = GetComponent<Renderer>();
        movie = (MovieTexture)render.material.mainTexture;
        audio = GetComponent<AudioSource>();
    }
}
