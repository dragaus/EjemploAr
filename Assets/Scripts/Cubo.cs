using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public Vector3 direccion;
    public float velocidad;

    void Update()
    {
        transform.Rotate(Time.deltaTime * velocidad * direccion);
    }
}
