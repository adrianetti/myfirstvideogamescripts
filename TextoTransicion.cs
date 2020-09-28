using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextoTransicion : MonoBehaviour
{
    public GameObject text1, text2;
    public GameObject Parpadeo;

    Animator animator;

    int texto = 1;
    // Start is called before the first frame update
    void Start()
    {
        animator = GameObject.Find("StoryOfMyLife").GetComponent<Animator>();

        Parpadeo.SetActive(false);
        text1.SetActive(false);
        text2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (texto)
            {
                case 1:
                    text1.SetActive(true); texto++; break;
                case 2:
                    text2.SetActive(true); texto++; break;
                case 3:
                    animator.SetTrigger("SoundFade");
                    Parpadeo.SetActive(true); texto++; break;
            }
        }
    }
}
