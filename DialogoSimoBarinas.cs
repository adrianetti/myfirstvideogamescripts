using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoSimoBarinas : MonoBehaviour
{
    public GameObject Dialogo, simoDialogo1, simoDialogo2, simoDialogo3;
    
    GameObject character, gallinaNegra;

    Animator gallinaNegraAnim;
    
    bool empezarDialogo = false, oneTime = true, secuencia = false;
    int escenaBarinas = 0;
   

    void Start()
    {
        gallinaNegraAnim = GameObject.Find("gallinanegra").GetComponent<Animator>();

        Dialogo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (empezarDialogo && oneTime)
        {
            character = GameObject.Find("Simoney");
            character.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;

            Dialogo.SetActive(true); simoDialogo2.SetActive(false); simoDialogo3.SetActive(false);

            oneTime = false;
            secuencia = true;
        }

        if(secuencia && Input.GetKeyDown(KeyCode.RightArrow))
        {
            switch (escenaBarinas)
            {
                case 0:
                    gallinaNegraAnim.SetTrigger("Dissapear");
                    simoDialogo1.SetActive(false);
                    simoDialogo2.SetActive(true);
                    escenaBarinas++; break;
                case 1:
                    simoDialogo2.SetActive(false);
                    simoDialogo3.SetActive(true);
                    escenaBarinas++; break;
                case 2:
                    Dialogo.SetActive(false);
                    character.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    escenaBarinas++; break;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        empezarDialogo = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        empezarDialogo = false;
    }
}
