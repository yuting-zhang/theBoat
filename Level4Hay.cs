using UnityEngine;
using System.Collections;

public class Level4Hay : MonoBehaviour {
    public UnityEngine.UI.Text guide;
    private bool gettingOut = false;
    private float rotatedAngle = 0;
    public GameObject cameraRig;
    public OVRPlayerController player;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (gettingOut && rotatedAngle > -90f) {
            cameraRig.transform.Rotate(Vector3.forward, -100 * Time.deltaTime, Space.World);
            rotatedAngle += -100 * Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider trig) {

        if (!gettingOut && trig.gameObject.tag == "Player") {
            guide.text = "Press X to get out of haystack";
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
    void OnTriggerStay(Collider trig) {
        if (gameObject.GetComponent<AudioSource>().time >= 1)
            gameObject.GetComponent<AudioSource>().Stop();

        if (trig.gameObject.tag == "Player") {
            if (Input.GetKey(KeyCode.Joystick1Button2)) {
                gettingOut = true;
                player.SetHaltUpdateMovement(false);
                guide.text = "";
            }
        }
    }
    void OnTriggerExit(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            guide.text = "";
        }
    }
}
