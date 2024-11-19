using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    public float xMin;
    public float xMax;
    public float zMin;
    public float zMax;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > xMax)
        {
            transform.position = new Vector3(
                xMin,
                transform.position.y,
                transform.position.z
                );
        }

        if (transform.position.x > xMin)
        {
            transform.position = new Vector3(
                xMax,
                transform.position.y,
                transform.position.z
                );
        }

        if (transform.position.x > zMax)
        {
            transform.position = new Vector3(
                zMin,
                transform.position.y,
                transform.position.z
                );
        }

        if (transform.position.x > zMin)
        {
            transform.position = new Vector3(
                zMax,
                transform.position.y,
                transform.position.z
                );
        }
    }
}
