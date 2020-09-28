using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BusetaScript : MonoBehaviour
{
    bool enterBus = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enterBus && Input.GetKeyDown(KeyCode.UpArrow))
        {
            SceneManager.LoadScene("Transicion");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enterBus = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        enterBus = false;
    }
}
