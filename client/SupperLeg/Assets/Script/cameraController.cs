using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {
    public GameObject target;
    public float angle = 0;
    public float pAngle = 0;
    public float distance = 0;
	// Use this for initialization
	void Start () {
        this.transform.position = target.transform.position;
        this.transform.forward = target.transform.forward;

    }

    // Update is called once per frame
    void Update () {
        Vector3 camerPosition = new Vector3(0, distance * Mathf.Sin(pAngle*Mathf.PI/180), -distance * Mathf.Cos(pAngle*Mathf.PI/180));
        this.transform.position = target.transform.position + camerPosition;
        this.transform.eulerAngles = new Vector3(angle,0,0);
	}
}
