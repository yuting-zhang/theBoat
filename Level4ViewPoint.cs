using UnityEngine;
using System.Collections;

public class Level4ViewPoint : MonoBehaviour {
    public UnityEngine.UI.Text guide;
    public OVRPlayerController controller;
    public GameObject player;
   

    private bool leapOfFaith;
    private bool jumped;

    // Use this for initialization
    void Start () {
        leapOfFaith = false;
        jumped = false;
	}
	
	// Update is called once per frame
	void Update () {
        print(player.transform.position.x);
	    if (leapOfFaith) {
            if (!jumped) {
                print("BOOM");

                Vector3 position = player.transform.position;
                print(position.x);
                position.x += 1 * Time.deltaTime;
                if (position.x >= 12.5)
                    jumped = true;
                player.transform.position = position;
                print(position.x);
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
                controller.GravityModifier = 0.5f;
                leapOfFaith = true;
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
