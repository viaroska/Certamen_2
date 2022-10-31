using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigosUno : MonoBehaviour
{ 

    public float rangodeAlerta;
    public LayerMask capadeJugador;
    bool estarAlerta;
    public Transform jugador;
    public float Velocidad;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        estarAlerta= Physics.CheckSphere(transform.position,rangodeAlerta,capadeJugador);

        if(estarAlerta==true)
        {
            transform.LookAt(new Vector3(jugador.position.x,transform.position.y,jugador.position.z));
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(jugador.position.x,transform.position.y,jugador.position.z), Velocidad * Time.deltaTime);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, rangodeAlerta);
    }
}
