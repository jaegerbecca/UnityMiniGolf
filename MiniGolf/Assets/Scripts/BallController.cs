using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{

    public float zForce = 0;

    public Camera MainCamera;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, -1, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, 1, 0);
        }

        MainCamera.GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity;

        Debug.Log(GetComponent<Rigidbody>().velocity);
    }

    private void OnMouseDrag()
    {
        zForce += 10;
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
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        zForce = 0;

    }
}
