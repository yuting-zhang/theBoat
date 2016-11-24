using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeckPortal : MonoBehaviour {

    // Use this for initialization

    public UnityEngine.UI.Text guide;
	void Start () {
	  
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            guide.text = "Press X to Enter the Cabin";
        }
    }

    IEnumerator loadNewScene() {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Level1");
    }

    void OnTriggerStay(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            if (Input.GetKey(KeyCode.Joystick1Button2)) {
                gameObject.GetComponent<AudioSource>().Play();
                StartCoroutine("loadNewScene");
            }
        }
    }

    void OnTriggerExit(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            guide.text = "";
        }
    }
}
