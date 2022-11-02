using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tocarobject : MonoBehaviour
{
    public AudioSource quienEmite;
    public AudioClip elSonido;
    public float volume = 1;
    


    private void OnTriggerEnter(Collider other)
    {
        quienEmite.PlayOneShot(elSonido, volume);
        Destroy(other.gameObject);

    }
}
