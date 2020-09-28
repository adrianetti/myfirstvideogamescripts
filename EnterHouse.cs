using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterHouse : MonoBehaviour
{
    bool enterHouse;

    GameObject upkey, character;
    

    // Start is called before the first frame update
    void Start()
    {
        character = GameObject.Find("Simoney");
        upkey = GameObject.Find("UpKey2");
        upkey.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (enterHouse && Input.GetKeyDown(KeyCode.UpArrow))
        {
            character.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            SceneManager.LoadScene("Puertas");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enterHouse = true;
        upkey.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        enterHouse = false;
        upkey.SetActive(false);
    }
}
