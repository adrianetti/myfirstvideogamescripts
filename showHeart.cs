using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showHeart : MonoBehaviour
{
    public GameObject heart;

    public void ShowHeart()
    {
        heart.SetActive(true);
    }
}
