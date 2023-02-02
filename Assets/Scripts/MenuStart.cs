using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuStart : MonoBehaviour
{
    public GameObject loadPanel;
    public AudioSource bgSource;
    public float deltaVolume = 10;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            bgSource.volume -= deltaVolume;
            loadPanel.SetActive(true);
        }
    }
}
