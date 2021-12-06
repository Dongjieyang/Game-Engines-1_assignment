using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate2 : MonoBehaviour
{
    public float rotSpeed;
    public GameObject pivotObject;
    public float xRot, yRot;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivotObject.transform.position, new Vector3(xRot, yRot, 0), rotSpeed * Time.deltaTime);
    }
}
