using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startAudio : MonoBehaviour
{
    AudioSource Yellow;

    // Start is called before the first frame update
    void Start()
    {
        Yellow = GameObject.Find("Yellow").GetComponent<AudioSource>();
        Yellow.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
