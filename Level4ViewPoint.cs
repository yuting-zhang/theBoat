using UnityEngine;
using System.Collections;

public class Level4ViewPoint : MonoBehaviour {
    public UnityEngine.UI.Text guide;
    public OVRPlayerController controller;
    public GameObject player;
    public GameObject airwall;
    public GameObject cameraRig;

    private bool leapOfFaith;
    private bool jumped;
    private float rotatedAngle;

    // Use this for initialization
    void Start () {
        leapOfFaith = false;
        jumped = false;
        rotatedAngle = 0;
	}
	
	// Update is called once per frame
	void Update () {
       
        if (leapOfFaith) {
            if (!jumped) {

                Vector3 position = player.transform.position;
                position.x += 3 * Time.deltaTime;
                position.y += 3 * Time.deltaTime;
                if (position.x >= 12.5)
                    jumped = true;
                player.transform.position = position;
                
            }
            if (rotatedAngle > -270f) {
                cameraRig.transform.Rotate(Vector3.forward, -50 * Time.deltaTime, Space.World);
                rotatedAngle += -50 * Time.deltaTime;               
            }
        }
	}

    void OnTriggerEnter(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            guide.text = "Press X to perform Leap of Faith";
        }
    }
    void OnTriggerStay(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            if (Input.GetKey(KeyCode.Joystick1Button2)) {
                controller.GravityModifier = 0.1f;
                leapOfFaith = true;
                guide.text = "";
                airwall.SetActive(false);
                gameObject.GetComponent<AudioSource>().Play();
                player.GetComponent<PlayerController>().SetHaltUpdateMovement(true);
            }
        }
    }

    void OnTriggerExit(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            guide.text = "";
        }
    }
}
