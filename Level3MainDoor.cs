using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Level3MainDoor : MonoBehaviour {

    // Use this for initialization
    public bool locked = true;
    public UnityEngine.UI.Text guide;
    void Start () {
	    
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
                if (locked)
                    guide.text = "Well, it is locked again...";
                else
                    SceneManager.LoadScene("MenuScene");

            }
        }
    }
    void OnTriggerExit(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            guide.text = "";
        }
    }
}
