using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transiciones : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Detecta si se presiona una tecla para caminar, si sí comienza caminar
        if (Input.GetKey("w"))
        {
            anim.SetBool("Movimiento", true);
        }
        else anim.SetBool("Movimiento", false);

        if (Input.GetKey("space"))
        {
            anim.SetBool("Salto", true);
        }
        else anim.SetBool("Salto", false);

        if (Input.GetKey("q"))
        {
            anim.SetBool("Corriendo", true);
        }
        else anim.SetBool("Corriendo", false);

        //Si el if anterior deja de ser cierto entonces termina el estado caminar

    }
}
