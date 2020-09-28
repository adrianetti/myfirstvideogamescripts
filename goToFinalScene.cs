using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToFinalScene : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("finalScene");
    }
}
