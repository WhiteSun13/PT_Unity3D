using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public GameObject[] songs;
    public int hour;
    public int minutes;
    public bool chislo;
    public bool Chas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Chas == true)
        {
            hour = System.DateTime.Now.Hour;
        }
        else
        {
            hour = System.DateTime.Now.Minute;
        }
        if (chislo == true && hour >= 10)
        {
            Perviy();
        }
        else if (chislo == true && hour < 10 && Chas == true)
        {
            OFFnic();
        }
        else if (chislo == true && hour < 10 && Chas == false)
        {
            Zero();
        }
        else if (chislo == false)
        {
            Vtoroe();
        }
    }
    void Perviy()
    {
        minutes = hour;
        if (minutes / 10 == 1)
        {
            One();
        }
        else if (minutes / 10 == 2)
        {
            Two();
        }
        else if (minutes / 10 == 3)
        {
            Three();
        }
        else if (minutes / 10 == 4)
        {
            Four();
        }
        else if (minutes / 10 == 5)
        {
            Five();
        }
        else if (minutes / 10 == 6)
        {
            Six();
        }
        else if (minutes / 10 == 7)
        {
            Seven();
        }
        else if (minutes / 10 == 8)
        {
            Eight();
        }
        else if (minutes / 10 == 9)
        {
            Nine();
        }
        else if (minutes / 10 == 0)
        {
            Zero();
        }
    }
    void Vtoroe()
    {
        minutes = hour;
        if (minutes % 10 == 1)
        {
            One();
        }
        else if (minutes % 10 == 2)
        {
            Two();
        }
        else if (minutes % 10 == 3)
        {
            Three();
        }
        else if (minutes % 10 == 4)
        {
            Four();
        }
        else if (minutes % 10 == 5)
        {
            Five();
        }
        else if (minutes % 10 == 6)
        {
            Six();
        }
        else if (minutes % 10 == 7)
        {
            Seven();
        }
        else if (minutes % 10 == 8)
        {
            Eight();
        }
        else if (minutes % 10 == 9)
        {
            Nine();
        }
        else if (minutes % 10 == 0)
        {
            Zero();
        }
    }
    void One()
    {
        songs[0].SetActive(true);
        songs[1].SetActive(true);
        songs[2].SetActive(false);
        songs[3].SetActive(false);
        songs[4].SetActive(false);
        songs[5].SetActive(false);
        songs[6].SetActive(false);
        songs[7].SetActive(false);
    }
    void Two()
    {
        songs[0].SetActive(true);
        songs[1].SetActive(false);
        songs[2].SetActive(true);
        songs[3].SetActive(false);
        songs[4].SetActive(false);
        songs[5].SetActive(true);
        songs[6].SetActive(true);
        songs[7].SetActive(true);
    }
    void Three()
    {
        songs[0].SetActive(true);
        songs[1].SetActive(true);
        songs[2].SetActive(true);
        songs[3].SetActive(true);
        songs[4].SetActive(false);
        songs[5].SetActive(false);
        songs[6].SetActive(true);
        songs[7].SetActive(true);
    }
    void Four()
    {
        songs[0].SetActive(true);
        songs[1].SetActive(true);
        songs[2].SetActive(true);
        songs[3].SetActive(false);
        songs[4].SetActive(true);
        songs[5].SetActive(false);
        songs[6].SetActive(false);
        songs[7].SetActive(false);
    }
    void Five()
    {
        songs[0].SetActive(false);
        songs[1].SetActive(true);
        songs[2].SetActive(true);
        songs[3].SetActive(false);
        songs[4].SetActive(true);
        songs[5].SetActive(false);
        songs[6].SetActive(true);
        songs[7].SetActive(true);
    }
    void Six()
    {
        songs[0].SetActive(false);
        songs[1].SetActive(true);
        songs[2].SetActive(true);
        songs[3].SetActive(true);
        songs[4].SetActive(true);
        songs[5].SetActive(true);
        songs[6].SetActive(true);
        songs[7].SetActive(true);
    }
    void Seven()
    {
        songs[0].SetActive(true);
        songs[1].SetActive(true);
        songs[2].SetActive(false);
        songs[3].SetActive(false);
        songs[4].SetActive(false);
        songs[5].SetActive(false);
        songs[6].SetActive(false);
        songs[7].SetActive(true);
    }
    void Eight()
    {
        songs[0].SetActive(true);
        songs[1].SetActive(true);
        songs[2].SetActive(true);
        songs[3].SetActive(true);
        songs[4].SetActive(true);
        songs[5].SetActive(true);
        songs[6].SetActive(true);
        songs[7].SetActive(true);
    }
    void Nine()
    {
        songs[0].SetActive(true);
        songs[1].SetActive(true);
        songs[2].SetActive(true);
        songs[3].SetActive(false);
        songs[4].SetActive(true);
        songs[5].SetActive(false);
        songs[6].SetActive(true);
        songs[7].SetActive(true);
    }
    void Zero()
    {
        songs[0].SetActive(true);
        songs[1].SetActive(true);
        songs[2].SetActive(false);
        songs[3].SetActive(false);
        songs[4].SetActive(true);
        songs[5].SetActive(true);
        songs[6].SetActive(true);
        songs[7].SetActive(true);
    }
    void OFFnic()
    {
        songs[0].SetActive(false);
        songs[1].SetActive(false);
        songs[2].SetActive(false);
        songs[3].SetActive(false);
        songs[4].SetActive(false);
        songs[5].SetActive(false);
        songs[6].SetActive(false);
        songs[7].SetActive(false);
    }
}
