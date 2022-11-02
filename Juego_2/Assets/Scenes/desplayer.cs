using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desplayer : MonoBehaviour
{
    void OntriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            Destroy(other.gameObject);
        }
    }
}
