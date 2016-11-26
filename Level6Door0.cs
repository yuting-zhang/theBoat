using UnityEngine;
using System.Collections;

public class Level6Door0 : MonoBehaviour {
    public OVRScreenFade camera;
    public UnityEngine.UI.Text guide;
    public GameObject player;
    public GameObject dest;

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
            if (Input.GetKey(KeyCode.Joystick1Button2)) {
                gameObject.GetComponent<AudioSource>().Play();
                StartCoroutine(camera.FadeIn());
                player.transform.position = dest.transform.position; 
                player.transform.rotation = dest.transform.rotation;
                player.transform.Rotate(0, 90, 0);

                if (Mathf.Abs(dest.transform.rotation.eulerAngles.y - 90) < 0.1) {
                    player.transform.Translate(0, 0, -1.5f, Space.World);
                }
                else {
                    
                    player.transform.Translate(0, 0, 1.5f, Space.World);
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
