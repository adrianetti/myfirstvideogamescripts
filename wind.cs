using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(9.81f,0f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
