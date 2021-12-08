using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScript : MonoBehaviour
{
    public float G;
    public GameObject Sun;
    void Start()
    {
        
    }

  
    void Update()
    {
        Gravity();
    }


    void Gravity()
    {
        float m1 = this.GetComponent<Rigidbody>().mass;
        float m2 = Sun.GetComponent<Rigidbody>().mass;
        float r = Vector3.Distance(Sun.transform.position, this.transform.position);

        this.GetComponent<Rigidbody>().AddForce((Sun.transform.position - this.transform.position).normalized * (G * (m2 - m1) / (r * r)));
    }
   
}
