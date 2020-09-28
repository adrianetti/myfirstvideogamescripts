using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bicicletaATrujillo : MonoBehaviour
{
    bool goTrujillo = false;

    Animator animator, animator2;

    GameObject character;

    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("Simoney");

        animator = GameObject.Find("LevelChanger").GetComponent<Animator>();
        animator2 = GameObject.Find("ComoTeExtraño").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (goTrujillo && Input.GetKeyDown(KeyCode.UpArrow))
        {
            character.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            animator2.SetTrigger("SoundFade");
            animator.SetTrigger("FadeIn");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        goTrujillo = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        goTrujillo = false;
    }
}
