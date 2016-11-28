using UnityEngine;
using System.Collections;

public class Level6StormStopper : MonoBehaviour {
   // public AudioSource audio;
   // private bool hasStopped = false;

	// Use this for initialization
	void Start () {
	    
	}

    // Update is called once per frame

    void OnTriggerEnter(Collider trig) {
        if (trig.gameObject.tag == "Player") {
           // hasStopped = true;
        }
    }
    void Update () {
        /*
        if (hasStopped) {
            if (audio.volume <= 0.01)
                audio.Stop();
            else
                audio.volume -= 0.1f * Time.deltaTime;
        }
        */
    }
}
