using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntos : MonoBehaviour
{
    
    public Transform puntoRojo;
    public Transform puntoAzul;
    void Start()
    {
        puntoRojo.transform.position = new Vector3(3, 2, 0);
        puntoAzul.transform.position = new Vector3(-3, 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        puntoRojo.transform.Rotate(0, 0, 100 * Time.deltaTime);
        puntoAzul.transform.Rotate(0, 0, 100 * Time.deltaTime);
    }
}
