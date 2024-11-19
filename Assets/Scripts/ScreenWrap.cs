using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;

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

        if (transform.position.x > yMax)
        {
            transform.position = new Vector3(
                yMin,
                transform.position.y,
                transform.position.z
                );
        }

        if (transform.position.x > yMin)
        {
            transform.position = new Vector3(
                yMax,
                transform.position.y,
                transform.position.z
                );
        }
    }
}