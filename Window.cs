using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Window : MonoBehaviour
{
    bool inDoor = false;
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
        if (inDoor && Input.GetKeyDown(KeyCode.UpArrow))
        {
            SceneManager.LoadScene("Sala");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        upKey.SetActive(true);
        inDoor = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        upKey.SetActive(false);
        inDoor = false;
    }
}
