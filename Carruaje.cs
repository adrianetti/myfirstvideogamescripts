using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carruaje : MonoBehaviour
{
    Animator carruaje;
    public float speed = 3.0f;

    bool trigger = false;
    // Start is called before the first frame update
    void Start()
    {
        carruaje = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(trigger == true){ 
        Vector2 position = transform.position;
        position.x = position.x + speed * Time.deltaTime;
        transform.position = position;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        trigger = true;
        carruaje.SetTrigger("StartMoving");
    }
}
