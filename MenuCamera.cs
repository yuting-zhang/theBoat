using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class MenuCamera : MonoBehaviour {
    public UnityEngine.UI.Text startLabel, guide;
    public GameObject labelObject;
    public GameObject menuCamera;
    private Color oldColor;

    // Use this for initialization
    void Start () {
        oldColor = startLabel.color;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 cameraPosition = menuCamera.transform.position;
        Vector3 cameraForward = menuCamera.transform.forward * 10000;

        bool eyeOnStart = false;

        RaycastHit hitInfo = new RaycastHit();
        if (Physics.Raycast(cameraPosition, cameraForward, out hitInfo)) {
            if (hitInfo.collider.gameObject == labelObject) {
                eyeOnStart = true;
            }
        }

        if (eyeOnStart) {
            startLabel.color = Color.red;
            guide.text = "Press A to select.";
        }
        else {
            startLabel.color = oldColor;
            guide.text = "Look at an option to highlight it.";
        }

        if (eyeOnStart) {
            print("Looking");
            if (Input.GetKey(KeyCode.Joystick1Button0)) {
                startLabel.color = oldColor;
                SceneManager.LoadScene("theBoat");
            }
        }
    }
}
