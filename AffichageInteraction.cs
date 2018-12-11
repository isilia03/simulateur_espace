using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AffichageInteraction : MonoBehaviour {

	public float intervalleInferieur;
	public float intervalleSuperieur;
	public GameObject informations;
	public GameObject camera;

	void Update () {
		
		if ((camera.transform.eulerAngles.y >= intervalleInferieur) && (camera.transform.eulerAngles.y <= intervalleSuperieur) && (Input.GetMouseButtonDown (0))) {
			if (informations.activeInHierarchy == false) {
				informations.SetActive (true);
			} 

			else {
				informations.SetActive (false);
			}
		}
	}
}
