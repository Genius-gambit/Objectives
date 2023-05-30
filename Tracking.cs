using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracking : MonoBehaviour
{
    public static int index;
    public int _info;
    bool _entry;
    public GameObject[] Images;

    private void Awake()
    {
        for (int i = 0; i < Images.Length; i++)
            Images[i].SetActive(false);
        index = 0;
        _info = 0;
        _entry = false;
    }

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.A) || OVRInput.GetDown(OVRInput.Button.One)) && _entry == true)
        {
            Images[_info].SetActive(false);
            _info++;
            AircraftController.ActivityStart = true;
            _entry = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Track")
            index++;
        if (other.tag == "InfoTag")
        {
            AircraftController.ActivityStart = false;
            Images[_info].SetActive(true);
            _entry = true;
        }
        other.transform.gameObject.SetActive(false);
    }
}
