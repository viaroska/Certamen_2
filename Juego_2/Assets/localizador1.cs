using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class localizador1 : MonoBehaviour
{
    public Transform objetivo;
    public NavMeshAgent agente;
    // Start is called before the first frame update
    void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        agente.destination = objetivo.position;
    }
}
