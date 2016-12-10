using UnityEngine;
using System.Collections;

public class Level9SoF : MonoBehaviour {

    public GameObject target;
    public GameObject endingCanvas;
    public GameObject player;
    public GameObject portal;

    public AudioSource as1;
    public AudioSource as2;
    public AudioSource as3;
    public AudioSource as4;

    private Vector3 dPosition;
    private Vector3 dRotation;
    private float totalTime = 0f;

	// Use this for initialization
	void Start () {
        Vector3 position = gameObject.transform.position;
        Vector3 targetPosition = target.transform.position;
        Vector3 rotation = gameObject.transform.rotation.eulerAngles;
        Vector3 targetRotation = target.transform.rotation.eulerAngles;

        rotation.x -= 360;

        print(targetRotation);
        print(rotation);
        dPosition = (targetPosition - position) / 30.0f;
        dRotation = (targetRotation - rotation) / 30.0f;
        print(dRotation);
        target.SetActive(false);

        as1.Play();
        as2.PlayDelayed(2);
        as3.PlayDelayed(6);
        as4.PlayDelayed(9);
    }
	
	// Update is called once per frame
	void Update () {

        totalTime += Time.deltaTime;
        if (totalTime > 30.0f) {
            endingCanvas.SetActive(true);
            portal.SetActive(true);
            as1.Stop();
            as2.Stop();
            as3.Stop();
            as4.Stop();
            return;
        }

        Vector3 position = player.transform.position;
        position.x += Random.Range(-0.01f, 0.01f) * Mathf.Max(0f, totalTime - 15);
        position.z += Random.Range(-0.01f, 0.01f) * Mathf.Max(0f, totalTime - 15);

        player.transform.position = position;

        gameObject.transform.position = gameObject.transform.position + dPosition * Time.deltaTime;
        gameObject.transform.rotation = Quaternion.Euler(gameObject.transform.rotation.eulerAngles + dRotation * Time.deltaTime);
    }
}
