using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Level4RealDoor : MonoBehaviour {
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

    IEnumerator loadNewScene() {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("MenuScene");
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
