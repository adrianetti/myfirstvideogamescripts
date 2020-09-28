using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ShowText : MonoBehaviour
{
    int i = 0;
    public GameObject text;
    public GameObject text2;
    public GameObject text3;

    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("space"))
        {
            switch (i)
            {
                case 0: 
                    text.SetActive(true);
                    i++;
                    break;
                case 1:
                    text2.SetActive(true);
                    i++;
                    break;
                case 2:
                    text3.SetActive(true);
                    i++;
                    break;
                case 3:

                    // Cambio de escena al cuarto de Simoney

                    SceneManager.LoadScene("CuartoSimo");
                    break;
            }
        }
    }
}
