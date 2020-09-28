using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUp : MonoBehaviour
{
    GameObject character;
    GameObject PointLight, dust, ZZZ, LKey;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        // Unable the character

        character = GameObject.Find("Simoney");
        character.GetComponent<Renderer>().enabled = false;
        character.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;

        PointLight = GameObject.Find("Point Light (1)");
        PointLight.SetActive(false);
        dust = GameObject.Find("Dust");
        dust.SetActive(false);

        ZZZ = GameObject.Find("ZZZ1");
        LKey = GameObject.Find("LKey2");



        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            ZZZ.SetActive(false);
            LKey.SetActive(false);
            animator.SetTrigger("WakeUp");
        }
    }

    public void ShowCharacter()
    {
        character.GetComponent<Renderer>().enabled = true;
        character.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        PointLight.SetActive(true);
        dust.SetActive(true);
    }
}
