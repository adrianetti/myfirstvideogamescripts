using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadNewMusic : MonoBehaviour
{
    AudioSource KuroshitsujiOp;

    // Start is called before the first frame update
    void Start()
    {
        EncenderRadio.Instance.gameObject.gameObject.GetComponent<AudioSource>().Pause();
        KuroshitsujiOp = GameObject.Find("KuroshitsujiOp").GetComponent<AudioSource>();
        KuroshitsujiOp.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
