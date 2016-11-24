using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level2MainDoorCollisionBox : MonoBehaviour {
    public UnityEngine.UI.Text guide;
    public GameObject mainDoor;
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
    IEnumerator loadNewScene() {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Level3");
    }
    void OnTriggerStay(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            if (Input.GetKey(KeyCode.Joystick1Button2)) {
                if (mainDoor.transform.localScale.z <= 18)
                    guide.text = "It's too small! Can't get through!";
                else {
                    gameObject.GetComponent<AudioSource>().Play();
                    StartCoroutine("loadNewScene");
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
