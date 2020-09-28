using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncenderRadio : MonoBehaviour
{
    AudioSource LainOp;
    public GameObject key;
    public GameObject radiolight;
    public GameObject notas;
    bool play;

    // Start is called before the first frame update
    void Start()
    {
        LainOp = GameObject.Find("LainOp").GetComponent<AudioSource>();
        key.SetActive(false);
        radiolight.SetActive(false);
        notas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (play && Input.GetKeyDown(KeyCode.S))
        {
            radiolight.SetActive(true);
            notas.SetActive(true);
            LainOp.Play();
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        key.SetActive(true);
        play = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        key.SetActive(false);
        play = false;
    }

    private static EncenderRadio instance = null;
    public static EncenderRadio Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

}
