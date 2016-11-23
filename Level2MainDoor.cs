using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Level2MainDoor : MonoBehaviour {

    public UnityEngine.UI.Text guide;
    public GameObject player;
    // Use this for initialization
    private float initialRatio;
    private Vector3 oldPlayerPosition;
    
    void Start() {
        initialRatio = Vector3.Distance(gameObject.transform.position, player.transform.position) / gameObject.transform.localScale.z;
        oldPlayerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update() {
        float y = player.transform.rotation.eulerAngles.y;
        Vector3 newPlayerPosition = player.transform.position;

        float oldDistance = Vector3.Distance(gameObject.transform.position, oldPlayerPosition);
        float newDistance = Vector3.Distance(gameObject.transform.position, newPlayerPosition);

        if (y >= 180 && Vector3.Distance(newPlayerPosition, oldPlayerPosition) > 0.01) {
            float oldScale = gameObject.transform.localScale.z;
            if (newDistance > oldDistance && oldScale < 20)
                gameObject.transform.localScale = new Vector3(oldScale + 0.01f, oldScale + 0.02f, oldScale + 0.02f);
            else if (newDistance < oldDistance && oldScale > 1)
                gameObject.transform.localScale = new Vector3(oldScale - 0.01f, oldScale - 0.02f, oldScale - 0.02f);
        }
        oldPlayerPosition = newPlayerPosition;
    }
   
}
