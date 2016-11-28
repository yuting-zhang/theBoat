using UnityEngine;
using System.Collections;

public class Level8Ceiling : MonoBehaviour {
    public PlayerController player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerStay(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            player.resetFallspeed();
        }
    }

}
