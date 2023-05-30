using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class AircraftController : MonoBehaviour
{
    #region Variables
    public GameObject PC21;
    public GameObject FinalMsg;
    public GameObject IntroControl;

    public Vector2 keys;

    public float _speedForce;
    public float _speedRotate;
    bool SpaceKey;
    public static bool ActivityStart;
    Dictionary<int, Action> methods = new Dictionary<int, Action>();
    #endregion

    #region BuiltIns Method

    private void Awake()
    {
        SpaceKey = false;
        FinalMsg.SetActive(false);
        ActivityStart = true;
        //methods.Add(1, MethodF);
        //methods.Add(2, MethodG);
        //methods.Add(3, MethodH);
        methods.Add(1, MethodA);
        methods.Add(3, MethodB);
        methods.Add(4, MethodC);
        methods.Add(6, MethodD);
        methods.Add(7, MethodE);
        methods.Add(8, MethodF);
        methods.Add(9, MethodG);
        methods.Add(10, MethodH);
        //IntroControl.GetComponent<Animator>().speed = 0;
        //IntroControl.GetComponent<Animator>().Play("IntroToControl");
        //IntroControl.GetComponent<Animator>().speed = 1;
    }
    private void Update()
    {
        //if (IntroControl.transform.gameObject.activeInHierarchy == true)
        //{
        //    if (Input.GetKeyDown(KeyCode.A) || OVRInput.GetDown(OVRInput.Button.One))
        //    {
        //        IntroControl.transform.gameObject.SetActive(false);
        //        ActivityStart = true;
        //    }
        //}
        GetControls();
    }

    private void FixedUpdate()
    {
        if (ActivityStart)
        {
            Acceleration();
            Rotating();
        }
    }
    #endregion

    #region Custom Methods
    void    GetControls()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SpaceKey = !SpaceKey;
        if (SpaceKey == true)
            keys.y = 1.0f;
        else
        {
            keys.y = Input.GetAxis("Vertical");
            keys.y = keys.y > 0.0f ? 1.0f : 0.0f;
        }
        if (FinalMsg.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.X) || OVRInput.GetDown(OVRInput.Button.Three))
                Application.Quit();
            else if (Input.GetKeyDown(KeyCode.A) || OVRInput.GetDown(OVRInput.Button.One))
                SceneManager.LoadScene(2);
        }
    }

    void    Acceleration()
    {
        PC21.transform.Translate(Vector3.forward * _speedForce * keys.y);
    }

    void    Rotating()
    {
        print("Index: " + Tracking.index);
        if (methods.ContainsKey(Tracking.index))
            methods[Tracking.index]();
    }
    #endregion

    #region Dictionary Functions
    void MethodA()
    {
        PC21.transform.Rotate(Vector3.down * 0.27f * keys.y);
    }
    void MethodB()
    {
        Vector3 tmp = new Vector3(0.0f, 180.0f, 0.0f);

        PC21.transform.localEulerAngles = Vector3.Lerp(PC21.transform.localEulerAngles, tmp, 0.025f);
    }
    void MethodC()
    {
        PC21.transform.Rotate(Vector3.up * 0.28f * keys.y);
    }
    void MethodD()
    {
        Vector3 tmp = new Vector3(0.0f, 270.0f, 0.0f);

        PC21.transform.localEulerAngles = Vector3.Lerp(PC21.transform.localEulerAngles, tmp, 0.015f);
    }
    void MethodE()
    {
        PC21.transform.Rotate(Vector3.up * 0.25f * keys.y);
    }
    void MethodF()
    {
        PC21.transform.Rotate(Vector3.up * 0.09f * keys.y);
    }
    void    MethodG()
    {
        Vector3 tmp = new Vector3(0.0f, 359.999f, 0.0f);

        if (PC21.transform.localEulerAngles.y != 360.0f)
        {
            Vector3 ret;

            ret = Vector3.Lerp(PC21.transform.localEulerAngles, tmp, 0.015f);
            if (ret.y > 360.0f || ret.y > 0 && ret.y < 180.0f)
                ret.y = 360.0f;
            PC21.transform.localEulerAngles = ret;
        }
    }

    void    MethodH()
    {
        ActivityStart = false;
        StartCoroutine(Finished());
    }

    IEnumerator Finished()
    {
        yield return null;
        FinalMsg.SetActive(true);
    }    
    #endregion
}
