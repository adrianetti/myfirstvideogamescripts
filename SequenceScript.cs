using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceScript : MonoBehaviour
{
    GameObject heart;
    GameObject parpado;


    // Start is called before the first frame update
    void Start()
    {
        parpado = GameObject.Find("parpadeo1");
        parpado.SetActive(false);

        heart = GameObject.Find("heart1");
        heart.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
