using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnFadeCompleteCocina : MonoBehaviour
{
    public void OnFadeComplete()
    {
        SceneManager.LoadScene("Garaje_Calle");
    }
}
