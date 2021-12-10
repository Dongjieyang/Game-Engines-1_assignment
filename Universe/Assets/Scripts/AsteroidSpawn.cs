using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour
{
    public int density;
    public float innerR,outerR,height;
    private Vector3 localPosition, offset, worldPosition;
    private float randomR, randomRandian, x, y, z;
    private float xRot, yRot, zRot;
    private GameObject asteroids;


    void Start()
    {

        for (int i = 0; i < density; i++)
        {
            asteroids = GameObject.CreatePrimitive(PrimitiveType.Cube);

            randomR = Random.Range(innerR, outerR);
            randomRandian = Random.Range(0, (2 * Mathf.PI));

            x = randomR * Mathf.Cos(randomRandian);
            y = Random.Range(-height, height);
            z = randomR * Mathf.Sin(randomRandian);



            localPosition = new Vector3(x, y, z);
            offset = transform.rotation * localPosition;
            worldPosition = offset + transform.position;

            xRot = Random.Range(0, 360);
            yRot = Random.Range(0, 360);
            zRot = Random.Range(0, 360);

            asteroids.transform.position = worldPosition;
            asteroids.transform.rotation = Quaternion.Euler(xRot, yRot, zRot);

            asteroids.transform.parent = this.transform;
        }
        
    }
}
