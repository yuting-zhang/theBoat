using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Level7MainDoor : MonoBehaviour {
    public UnityEngine.UI.Text guide;
    public GameObject backDoor;
    public AudioClip openClip;
    public int counter = 0;
    private float deltaTime = 0f;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator loadNewScene() {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Level8");
    }

    

    void OnTriggerEnter(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            guide.text = "Press X to open the door";
        }
    }


    void OnTriggerStay(Collider trig) {
        deltaTime += Time.deltaTime;
        if (trig.gameObject.tag == "Player") {
            if (Input.GetKey(KeyCode.Joystick1Button2)) {
                
                if (deltaTime < 0.5f)
                    return;

                deltaTime = 0f;
                counter++;

                if (backDoor.GetComponent<Level7BackDoor>().counter == 3 && counter == 2) {
                    gameObject.GetComponent<AudioSource>().clip = openClip;
                    gameObject.GetComponent<AudioSource>().Play();
                    StartCoroutine("loadNewScene");
                }
                else if (counter > 2) {
                    counter = 0;
                    backDoor.GetComponent<Level7BackDoor>().counter = 0;
                    backDoor.GetComponent<AudioSource>().PlayDelayed(0.1f);
                    gameObject.GetComponent<AudioSource>().Play();
                }
                else
                    gameObject.GetComponent<AudioSource>().Play();

            }
        }
    }
    void OnTriggerExit(Collider trig) {
        if (trig.gameObject.tag == "Player") {
            guide.text = "";
        }
    }
}
