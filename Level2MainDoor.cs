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

        if ((y <= 270 + 45 && y >= 270 - 45) && Vector3.Distance(newPlayerPosition, oldPlayerPosition) > 0.001) {
            float goalScale = newDistance / initialRatio;
            float scale = gameObject.transform.localScale.z;

            if (scale < goalScale)
                scale += 0.1f;
            else
                scale -= 0.1f;
            gameObject.transform.localScale = new Vector3(scale, scale, scale);
       
        }
        oldPlayerPosition = newPlayerPosition;
    }
   
}
