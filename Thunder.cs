using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunder : MonoBehaviour
{
    Animator animator;
    AudioSource thunderSound;
    bool lightning = true;

    // Start is called before the first frame update
    void Start()
    {
        thunderSound = GetComponent<AudioSource>();
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetTrigger("Thunder");

        if (lightning)
        {
            thunderSound.Play();
            lightning = false;
        }

    }
}
