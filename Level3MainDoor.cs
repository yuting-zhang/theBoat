﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Level3MainDoor : MonoBehaviour {
    public AudioClip openClip;

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

    IEnumerator loadNewScene() {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Level4");
    }

    void OnTriggerStay(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            if (Input.GetKey(KeyCode.Joystick1Button2)) {
                if (locked) {
                    guide.text = "Well, it is locked again...";
                    gameObject.GetComponent<AudioSource>().Play();
                }
                else {
                    gameObject.GetComponent<AudioSource>().clip = openClip;
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
