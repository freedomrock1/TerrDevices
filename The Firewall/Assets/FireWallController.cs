using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FireWallController : MonoBehaviour
{

    public bool isClose = false;

	// Use this for initialization
	void Start ()
    {
        Cursor.visible = true;
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (isClose && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Firewall");
        }

	}


    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isClose = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            isClose = false;
        }
    }
}
