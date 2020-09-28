using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerGaraje : MonoBehaviour
{
    bool canPass = false;
    GameObject upKey;

    GameObject character;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("Simoney");


        upKey = GameObject.Find("UpKey1");
        upKey.SetActive(false);

        animator = GameObject.Find("LevelChanger").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canPass && Input.GetKeyDown(KeyCode.UpArrow))
        {
            character.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            animator.SetTrigger("FadeIn");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canPass = true;
        upKey.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canPass = false;
        upKey.SetActive(false);
    }

}
