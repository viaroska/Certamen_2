using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public CharacterController player1;
    public float velocidad;


    // Start is called before the first frame update
    void Start()
    {
        player1 = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        player1.Move(new Vector3(horizontal, 0, vertical) * velocidad * Time.deltaTime);
    }
}
