using UnityEngine;
using System.Collections;

public class Level4BackDoor : MonoBehaviour {

    // Use this for initialization
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
            if (Input.GetKey(KeyCode.Joystick1Button2)) {
                guide.text = "No surprise. It's locked...";
                gameObject.GetComponent<AudioSource>().Play();
            }
        }
    }
    void OnTriggerExit(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            guide.text = "";
        }
    }
}
