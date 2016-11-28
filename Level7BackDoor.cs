using UnityEngine;
using System.Collections;

public class Level7BackDoor : MonoBehaviour {

    public GameObject mainDoor;
    public int counter = 0;

    public UnityEngine.UI.Text guide;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    

    void OnTriggerEnter(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            guide.text = "Press X to open the door";
        }
    }

   

    void OnTriggerStay(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            if (Input.GetKeyDown(KeyCode.Joystick1Button2)) {
                gameObject.GetComponent<AudioSource>().Play();
                counter++;
                if (counter > 3) {
                    counter = 0;
                    mainDoor.GetComponent<Level7MainDoor>().counter = 0;
                    mainDoor.GetComponent<AudioSource>().PlayDelayed(0.1f);
                }
            }
        }
    }
    void OnTriggerExit(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            guide.text = "";
        }
    }
}
