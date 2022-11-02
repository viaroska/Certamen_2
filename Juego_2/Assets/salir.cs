using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class salir : MonoBehaviour
{
   public void Exit()
    {
        Application.Quit();
        SceneManager.LoadScene("SampleScene 1");
    }
}
