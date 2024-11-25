using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoawnManager : MonoBehaviour
{
    public GameManager gm;
    public float horizontalRange;
    public float verticalRange;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        horizontalRange = gm.horizontalLimit;
        verticalRange = gm.verticalLimit;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 GenerateRandomPosition()
    {
        float randomX = Random.Range(-horizontalRange, horizontalRange);
        float randomY = Random.Range(-verticalRange, verticalRange);

        return new Vector3(randomX, randomY, 0);
    }
}
