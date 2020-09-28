using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class primerDialogo : MonoBehaviour
{
    public GameObject character;
    public GameObject dialogo, adrian, simoney;
    public GameObject dialogoadrian1;
    public GameObject dialogoadrian2;

    bool empezarDialogo = false;
    bool oneTime = true;
    bool siguiente;

    int texto = 0;

    // Start is called before the first frame update
    void Start()
    {
        dialogo.SetActive(false);
        dialogoadrian2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (empezarDialogo && oneTime)
        {
            dialogo.SetActive(true);
            simoney.SetActive(false);
            character.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;

            siguiente = true;
            oneTime = false;
        }

        if (siguiente && Input.GetKeyDown(KeyCode.RightArrow))
        {
            switch (texto)
            {
                case 0:
                    texto++;
                    break;
                case 1:
                    adrian.SetActive(false);
                    dialogoadrian1.SetActive(false);
                    simoney.SetActive(true);
                    texto++; break;
                case 2:
                    simoney.SetActive(false);
                    adrian.SetActive(true);
                    dialogoadrian2.SetActive(true);
                    texto++; break;
                case 3:
                    dialogo.SetActive(false);
                    character.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    texto++;  break;
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
