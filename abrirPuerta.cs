using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrirPuerta : MonoBehaviour
{
    bool doorOpen = false;
    GameObject puertaAbierta;
    GameObject rejasCollider;

    GameObject Okey;

    // Start is called before the first frame update
    void Start()
    {
        Okey = GameObject.Find("OKey1");
        Okey.SetActive(false);
        rejasCollider = GameObject.Find("rejas");

        puertaAbierta = GameObject.Find("puertaGaraje1");
        puertaAbierta.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (doorOpen && Input.GetKeyDown(KeyCode.O))
        {
            Destroy(Okey);
            puertaAbierta.SetActive(true);
            Destroy(rejasCollider.GetComponent<BoxCollider2D>());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Okey.SetActive(true);
        doorOpen = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Okey.SetActive(false);
        doorOpen = false;
    }
}
