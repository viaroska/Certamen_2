using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject canvas1;
    public Text txtplayer;
    
    private void OnTriggerEnter(Collider player2)
    {
        if (player2.name == "cube")
        {
            canvas1.SetActive(true);
            txtplayer.text = "Felicitaciones has ganado  ";
        }
    }
}
