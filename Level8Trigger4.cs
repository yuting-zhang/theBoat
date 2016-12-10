using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level8Trigger4 : MonoBehaviour {
    private bool entered = false;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter(Collider trig) {
        if (!entered && trig.gameObject.tag == "Player") {
            foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Level4")) {
                obj.AddComponent<Rigidbody>();
                obj.GetComponent<Rigidbody>().AddForce(0, Random.Range(0.5f, 1f), 0);
            }
            entered = true;
        }
    }
}
