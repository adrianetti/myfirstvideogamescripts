using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoTrujillo : MonoBehaviour
{
    GameObject character;

    public GameObject dialogo;
    public GameObject simoney, medico;
    public GameObject dialogoSimoney1, dialogoSimoney2;

    bool empezarDialogo = false, oneTime = true, secuencia = false;

    int aux = 0;


    void Start()
    {
        character = GameObject.Find("Simoney");

        dialogo.SetActive(false);
        dialogoSimoney2.SetActive(false);
        medico.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (empezarDialogo && oneTime)
        {
            character.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            dialogo.SetActive(true);

            oneTime = false;
            secuencia = true;
        }

        if (secuencia && Input.GetKeyDown(KeyCode.RightArrow))
        {
            switch (aux)
            {
                case 0:
                    dialogoSimoney1.SetActive(false);
                    simoney.SetActive(false);
                    medico.SetActive(true);
                    aux++; break;
                case 1:
                    medico.SetActive(false);
                    simoney.SetActive(true);
                    dialogoSimoney2.SetActive(true);
                    aux++; break;
                case 2:
                    dialogo.SetActive(false);
                    character.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    aux++; break;
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
