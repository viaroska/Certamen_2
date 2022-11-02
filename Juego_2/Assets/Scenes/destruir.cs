using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destruir : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "eliminar")
         //   Destroy(other.gameObject);
 print("jugador eliminado");
        SceneManager.LoadScene("SampleScene 1");
       
    }
}
