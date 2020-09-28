using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class srtartAudio2 : MonoBehaviour
{
    AudioSource ComoTeExtraño;
    // Start is called before the first frame update
    void Start()
    {
        ComoTeExtraño = GameObject.Find("ComoTeExtraño").GetComponent<AudioSource>();
        ComoTeExtraño.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
