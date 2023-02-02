using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WS : MonoBehaviour
{
    private Animator anim;
    public int levelToLoad;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}