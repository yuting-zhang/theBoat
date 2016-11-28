﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level6RealDoor : MonoBehaviour {

    public UnityEngine.UI.Text guide;

    void OnTriggerEnter(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            guide.text = "Press X to open the door";
        }
    }

    IEnumerator loadNewScene() {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Level7");
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
