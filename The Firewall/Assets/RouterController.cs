using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RouterController : MonoBehaviour
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

	    if(isClose && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Router");
        }

	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isClose = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isClose = false;
        }
    }


}
