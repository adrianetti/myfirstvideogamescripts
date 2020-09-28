using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransicionPasilloCocina : MonoBehaviour
{
    bool canPass = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canPass)
        {
            SceneManager.LoadScene(2);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canPass = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canPass = false;
    }
}
