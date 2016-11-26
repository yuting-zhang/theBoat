using UnityEngine;
using System.Collections;

public class Level5StormTrigger : MonoBehaviour {
    public GameObject shipObject;
    private bool storm = false;
    private float portDegree = 0;
    private bool port = true;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (storm) {
            float degreeChanged = 0;
            if (port)
                degreeChanged = -Random.Range(5, 10) * Time.deltaTime;
            else
                degreeChanged = Random.Range(5, 10) * Time.deltaTime;

            shipObject.transform.Rotate(degreeChanged, 0, 0);
            portDegree += degreeChanged;
            if (portDegree < -30)
                port = false;
            else if (portDegree > 30)
                port = true;
        }
	}

    void OnTriggerEnter(Collider trig) {
        if (!storm) {
            storm = true;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }

}
