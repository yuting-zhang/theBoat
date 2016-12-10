using UnityEngine;
using System.Collections;

public class Level4FallVibrate : MonoBehaviour {
    public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            Vector3 position = player.transform.position;
            position.x += Random.Range(-0.1f, 0.1f);
            position.z += Random.Range(-0.1f, 0.1f);
            if (position.x > 13 || position.x < 12)
                return;
            if (position.z < -26.5 || position.z > -24.5)
                return;
            player.transform.position = position;
        }
    }
}
