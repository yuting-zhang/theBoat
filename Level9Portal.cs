using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level9Portal : MonoBehaviour {

    // Use this for initialization

    public UnityEngine.UI.Text guide;
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            guide.text = "Press X to Aboard Spirit of Fire";
        }
    }

    IEnumerator loadNewScene() {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("MenuScene");
    }

    void OnTriggerStay(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            if (Input.GetKey(KeyCode.Joystick1Button2)) {
                guide.text = "Ship not available in Demo. Now returning to Menu...";
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
