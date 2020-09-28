using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransicionSalaCocina : MonoBehaviour
{
    bool canPass;
    GameObject upKey;

    // Start is called before the first frame update
    void Start()
    {
        upKey = GameObject.Find("UpKey1");
        upKey.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (canPass && Input.GetKeyDown(KeyCode.UpArrow))
        {
            SceneManager.LoadScene("Cocina");
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
