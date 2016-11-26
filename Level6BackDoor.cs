using UnityEngine;
using System.Collections;

public class Level6BackDoor : MonoBehaviour {

    public UnityEngine.UI.Text guide;

    private GameObject door0;
    private GameObject door1;
    private GameObject door2;
    private GameObject door3;
    private GameObject door4;
    private GameObject door5;
    private GameObject door6;
    private GameObject door7;
    private GameObject door8;
    private GameObject door9;
    private GameObject door10;

    
    // Use this for initialization
    void Start() {
        door0 = GameObject.Find("Door0");
        door1 = GameObject.Find("Door1");
        door2 = GameObject.Find("Door2");
        door3 = GameObject.Find("Door3");
        door4 = GameObject.Find("Door4");
        door5 = GameObject.Find("Door5");
        door6 = GameObject.Find("Door6");
        door7 = GameObject.Find("Door7");
        door8 = GameObject.Find("Door8");
        door9 = GameObject.Find("Door9");
        door10 = GameObject.Find("Door10");

        door0.GetComponent<Level6Door0>().dest = door1;
        door1.GetComponent<Level6Door0>().dest = door5;
        door2.GetComponent<Level6Door0>().dest = door8;
        door3.GetComponent<Level6Door0>().dest = door4;
        door4.GetComponent<Level6Door0>().dest = door9;
        door5.GetComponent<Level6Door0>().dest = door2;
        door6.GetComponent<Level6Door0>().dest = door8;
        door7.GetComponent<Level6Door0>().dest = door6;
        door8.GetComponent<Level6Door0>().dest = door3;
        door9.GetComponent<Level6Door0>().dest = door10;
        door10.GetComponent<Level6Door0>().dest = door7;
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
                guide.text = "Well, locked... No doubt, no doubt...";
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
