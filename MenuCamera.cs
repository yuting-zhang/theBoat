using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class MenuCamera : MonoBehaviour {
    public UnityEngine.UI.Text startLabel, guide, selectLabel, hideLabel;
    public UnityEngine.UI.Text level0Label;
    public UnityEngine.UI.Text level1Label;
    public UnityEngine.UI.Text level2Label;
    public UnityEngine.UI.Text level3Label;
    public UnityEngine.UI.Text level4Label;
    public UnityEngine.UI.Text level5Label;
    public UnityEngine.UI.Text level6Label;
    public UnityEngine.UI.Text level7Label;
    public UnityEngine.UI.Text level8Label;
    public UnityEngine.UI.Text level9Label;


    public GameObject startLabelObject, selectLabelObject, hideLabelObject;
    public GameObject level0LableObject;
    public GameObject level1LableObject;
    public GameObject level2LableObject;
    public GameObject level3LableObject;
    public GameObject level4LableObject;
    public GameObject level5LableObject;
    public GameObject level6LableObject;
    public GameObject level7LableObject;
    public GameObject level8LableObject;
    public GameObject level9LableObject;

    public GameObject selectCanvas;
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

        int action = 0; // 0 no action, 1 start game, 2 select level, 3 go back, 10 - 19 start level 0 - 9 
        UnityEngine.UI.Text labelSelected = null;

        RaycastHit hitInfo = new RaycastHit();
        if (Physics.Raycast(cameraPosition, cameraForward, out hitInfo)) {
            if (hitInfo.collider.gameObject == startLabelObject) {
                action = 1;
                labelSelected = startLabel;
            }
            if (hitInfo.collider.gameObject == selectLabelObject) {
                action = 2;
                labelSelected = selectLabel;
            }
            if (hitInfo.collider.gameObject == hideLabelObject) {
                action = 3;
                labelSelected = hideLabel;
            }
            if (hitInfo.collider.gameObject == level0LableObject) {
                action = 10;
                labelSelected = level0Label;
            }
            if (hitInfo.collider.gameObject == level1LableObject) {
                action = 11;
                labelSelected = level1Label;
            }
            if (hitInfo.collider.gameObject == level2LableObject) {
                action = 12;
                labelSelected = level2Label;
            }
            if (hitInfo.collider.gameObject == level3LableObject) {
                action = 13;
                labelSelected = level3Label;
            }
            if (hitInfo.collider.gameObject == level4LableObject) {
                action = 14;
                labelSelected = level4Label;
            }
            if (hitInfo.collider.gameObject == level5LableObject) {
                action = 15;
                labelSelected = level5Label;
            }
            if (hitInfo.collider.gameObject == level6LableObject) {
                action = 16;
                labelSelected = level6Label;
            }
            if (hitInfo.collider.gameObject == level7LableObject) {
                action = 17;
                labelSelected = level7Label;
            }
            if (hitInfo.collider.gameObject == level8LableObject) {
                action = 18;
                labelSelected = level8Label;
            }
            if (hitInfo.collider.gameObject == level9LableObject) {
                action = 19;
                labelSelected = level9Label;
            }
        }

        if (labelSelected) {
            labelSelected.color = Color.red;
            guide.text = "Press A to select.";
        }
        else {
            startLabel.color = oldColor;
            selectLabel.color = oldColor;
            hideLabel.color = oldColor;
            level0Label.color = oldColor;
            level1Label.color = oldColor;
            level2Label.color = oldColor;
            level3Label.color = oldColor;
            level4Label.color = oldColor;
            level5Label.color = oldColor;
            level6Label.color = oldColor;
            level7Label.color = oldColor;
            level8Label.color = oldColor;
            level9Label.color = oldColor;
            guide.text = "Look at an option to highlight it.";
        }

        if (action != 0) {
            if (Input.GetKey(KeyCode.Joystick1Button0)) {
                startLabel.color = oldColor;
                selectLabel.color = oldColor;
                hideLabel.color = oldColor;
                level0Label.color = oldColor;
                level1Label.color = oldColor;
                level2Label.color = oldColor;
                level3Label.color = oldColor;
                level4Label.color = oldColor;
                level5Label.color = oldColor;
                level6Label.color = oldColor;
                level7Label.color = oldColor;
                level8Label.color = oldColor;
                level9Label.color = oldColor;

                switch (action) {
                case 1:
                    SceneManager.LoadScene("theBoat");
                    break;
                case 2:
                    selectCanvas.SetActive(true);
                    break;
                case 3:
                    selectCanvas.SetActive(false);
                    break;
                case 10:
                    SceneManager.LoadScene("theBoat");
                    break;
                case 11:
                    SceneManager.LoadScene("Level1");
                    break;
                case 12:
                    SceneManager.LoadScene("Level2");
                    break;
                case 13:
                    SceneManager.LoadScene("Level3");
                    break;
                case 14:
                    SceneManager.LoadScene("Level4");
                    break;
                case 15:
                    SceneManager.LoadScene("Level5");
                    break;
                case 16:
                    SceneManager.LoadScene("Level6");
                    break;
                case 17:
                    SceneManager.LoadScene("Level7");
                    break;
                case 18:
                    SceneManager.LoadScene("Level8");
                    break;
                case 19:
                    SceneManager.LoadScene("Level9");
                    break;
                default:
                    break;
                }
                
            }
        }
    }
}
