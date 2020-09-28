using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;
using UnityEngine.SceneManagement;

public class SitDown : MonoBehaviour
{
    GameObject character, PointLight, dust;
    GameObject iluminacion;
    GameObject key;
    GameObject parpado, heart;

    Animator adrianmueble;

    bool canSit = false;
    bool sequence = false;

    int escenaAdrian = 0;


    public GameObject dialogo, adrian, simoney;
    public GameObject dialogoAdrian1, dialogoAdrian2, dialogoAdrian3;
    public GameObject dialogoSimoney1, dialogoSimoney2;


    // Start is called before the first frame update
    void Start()
    {
        
        iluminacion = GameObject.Find("Point Light");
        iluminacion.SetActive(false);

        parpado = GameObject.Find("parpadeo1");
        parpado.SetActive(false);

        heart = GameObject.Find("heart1");
        heart.SetActive(false);

        key = GameObject.Find("UpKey1");
        key.SetActive(false);

        adrianmueble = GameObject.Find("adrianmueble1").gameObject.GetComponent<Animator>();

        dialogo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (canSit && Input.GetKeyDown(KeyCode.UpArrow))
        {
            adrianmueble.SetTrigger("simoneyIn");

            iluminacion.SetActive(true);

            character = GameObject.Find("Simoney");
            character.GetComponent<Renderer>().enabled = false;
            character.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;

            PointLight = GameObject.Find("Point Light (1)");
            PointLight.SetActive(false);
            dust = GameObject.Find("Dust");
            dust.SetActive(false);

            dialogo.SetActive(true);
            dialogoAdrian2.SetActive(false); dialogoAdrian3.SetActive(false);
            simoney.SetActive(false);

            sequence = true; // Se puede proceder a las animaciones
        }

        if (sequence && Input.GetKeyDown(KeyCode.RightArrow))
        {
            switch (escenaAdrian)
            {

                //  Resolviendo la escena por pasos, cada LeftArrow, una animación, o lo que se necesite

                case 0:
                    dialogoAdrian1.SetActive(false);
                    adrian.SetActive(false);
                    simoney.SetActive(true);
                    dialogoSimoney2.SetActive(false);
                    escenaAdrian++; break;
                case 1:
                    simoney.SetActive(false);
                    adrian.SetActive(true);
                    dialogoAdrian2.SetActive(true);
                    escenaAdrian++; break;
                case 2:
                    dialogoAdrian2.SetActive(false);
                    adrian.SetActive(false);
                    simoney.SetActive(true);
                    escenaAdrian++; break;
                case 3:
                    dialogoSimoney1.SetActive(false);
                    simoney.SetActive(false);
                    adrian.SetActive(true);
                    dialogoAdrian3.SetActive(true);
                    escenaAdrian++; break;
                case 4:
                    adrian.SetActive(false);
                    simoney.SetActive(true);
                    dialogoSimoney2.SetActive(true);
                    escenaAdrian++; break;
                case 5:
                    dialogo.SetActive(false);
                    adrianmueble.SetTrigger("adrianWithSimoney");
                    escenaAdrian++; break;
                case 6:
                    parpado.SetActive(true);
                    escenaAdrian++; break;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canSit = true;
        key.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canSit = false;
        key.SetActive(false);
    }
}
