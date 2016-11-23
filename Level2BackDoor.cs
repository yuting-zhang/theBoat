using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level2BackDoor : MonoBehaviour {

    public UnityEngine.UI.Text guide;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            guide.text = "Press X to open the door";
        }
    }
    void OnTriggerStay(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            if (Input.GetKey(KeyCode.Joystick1Button2))
                guide.text = "Locked... Who did it?";
        }
    }

    void OnTriggerExit(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            guide.text = "";
        }
    }
}
