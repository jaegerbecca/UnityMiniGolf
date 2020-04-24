using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{

    public float zForce = 0;
	
	public GameObject arrowHead;
	public GameObject arrowStem;

    public Camera MainCamera;

    void Start()
    {
        arrowHead = GameObject.Find("arrowHead");
		arrowStem = GameObject.Find("arrowStem");
    }

    void Update()
    {
        if (Input.GetKey("a") && zForce == 0)
        {
            transform.Rotate(0, -1, 0);
        }
        if (Input.GetKey("d") && zForce == 0)
        {
            transform.Rotate(0, 1, 0);
        }
		
		arrowHead.GetComponent<MeshRenderer>().enabled = zForce == 0 ? true : false;
		arrowStem.GetComponent<MeshRenderer>().enabled = zForce == 0 ? true : false;
		

        MainCamera.GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity;

        Debug.Log(GetComponent<Rigidbody>().velocity.z);
    }

    private void OnMouseDrag()
    {
		if (zForce < 2250) {
			zForce += 10;
		}
    }

    private void OnMouseUp()
    {
        GetComponent<Rigidbody>().AddRelativeForce(0, 0, zForce);
        StartCoroutine(stopball());
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "cup1")
        {
            SceneManager.LoadScene("hole2");
        }
    }

    IEnumerator stopball()
    {
        yield return new WaitForSeconds(5);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        transform.localEulerAngles = new Vector3(0, 0, 0);
		MainCamera.transform.localPosition = new Vector3(0, 6, -8);
		MainCamera.transform.localEulerAngles = new Vector3(25, 0, 0);
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        zForce = 0;

    }
	
	void OnGUI()
    {
        GUI.Box(new Rect((Screen.width / 2) - Screen.width / 10, 0, Screen.width / 5, Screen.height / 12), "zForce: " + zForce);
    }
}
