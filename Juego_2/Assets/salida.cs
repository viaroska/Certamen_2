using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class salida : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        print("juego finalizado");
        SceneManager.LoadScene("SampleScene 1");
    }

}
