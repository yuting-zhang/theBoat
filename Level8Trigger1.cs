using UnityEngine;
using System.Collections;

public class Level8Trigger1 : MonoBehaviour {

    public PlayerController player;
    private bool entered = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider trig) {
        if (!entered && trig.gameObject.tag == "Player") {
            foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Level1")) {
                obj.AddComponent<Rigidbody>();
            }
            Physics.gravity = -Physics.gravity * 0.03f;
            player.GravityModifier = 0.1f;
            entered = true;
            player.JumpForce = 0.01f;
            player.Jump();
        }
    }
}
