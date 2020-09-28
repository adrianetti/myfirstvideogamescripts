using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene1: MonoBehaviour
{
   
    public Animator animator;
    private int LevelToLoad;
   
    public void OnTriggerEnter2D(Collider2D other)
    {
        FadeToLevel();
        animator.SetTrigger("FadeOut");

    }

    public void FadeToLevel ()
    {
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(1);
    }


}
