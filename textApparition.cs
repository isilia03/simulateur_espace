using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textApparition : MonoBehaviour {

    //Attach an Image you want to fade in the GameObject's Inspector
    public Text m_Image;
    private bool delete = false;

    void Awake()
    {
        m_Image.CrossFadeAlpha(0, 0.0f, true);

        Camera.main.transform.rotation = Quaternion.identity;
        Camera.main.transform.eulerAngles = new Vector3(0, 0, 0);
    }

    void Update()
    {
        //Debug.Log(Time.time);
        if ((Time.time > 2.0f) && (delete == false))
        {
            m_Image.CrossFadeAlpha(1, 2.0f, true);

            Camera.main.transform.rotation = Quaternion.identity;
            Camera.main.transform.eulerAngles = new Vector3(0, 0, 0);

            if (Time.time > 8.0f)
            {
                delete = true;
            }
        }

        else if ((Time.time > 8.0f) && (delete == true))
        {
            m_Image.CrossFadeAlpha(0, 2.0f, true);
        }
    }
}
