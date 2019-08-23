using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visible : MonoBehaviour {

	public GameObject description;
    private bool entered = false;
    private bool actif = false;

    void Update()
	{
		if ((entered == true) && (Input.GetMouseButtonDown(1)) && (actif == false))
        {
            description.SetActive(true);
            actif = true;
        }

        else if ((entered == true) && (Input.GetMouseButtonDown(1)) && (actif == true))
        {
            description.SetActive(false);
            actif = false;
        }

        else if (entered == false)
        {
            description.SetActive(false);
            actif = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            entered = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            entered = false;
            description.SetActive(false);
        }
    }
}
