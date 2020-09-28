using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToRoom : MonoBehaviour
{
    bool canEnter = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (canEnter && Input.GetKeyDown(KeyCode.UpArrow))
        {
            SceneManager.LoadScene("Hogar");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canEnter = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canEnter = false;
    }
}
