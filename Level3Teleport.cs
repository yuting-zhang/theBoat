using UnityEngine;
using System.Collections;

public class Level3Teleport : MonoBehaviour {

    public GameObject player;
    public Level3MainDoor door;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider trig) {
        Vector3 position = player.transform.position;
        position.y += 10.27f - 6.027f;
        player.transform.position = position;
        door.locked = false;
    }
}
