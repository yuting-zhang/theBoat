using UnityEngine;
using System.Collections;

public class Level8Trigger2 : MonoBehaviour {
    private bool entered = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider trig) {
        if (!entered && trig.gameObject.tag == "Player") {
            foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Level2")) {
                obj.AddComponent<Rigidbody>();
                obj.GetComponent<Rigidbody>().AddForce(0, Random.Range(0.5f, 1f), 0);
            }
            entered = true;
        }
    }
}
