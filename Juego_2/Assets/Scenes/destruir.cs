using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruir : MonoBehaviour
{
    void OntriggerEnter(Collider other)
    {
        if (other.tag == "enemigo")
        {
            Destroy(gameObject);
        }
    }
}
