using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadNew()
    {
        SceneManager.LoadScene(2);
    }
    public void Load1()
    {
        if (JobCounter.contador >= 4)
        {
            SceneManager.LoadScene(2);
        }
    }
    public void Load2()
    {
        if (JobCounter.contador >= 4)
        {
            SceneManager.LoadScene(3);
        }
    }
    public void Load3()
    {
        if (JobCounter.contador >= 4)
        {
            SceneManager.LoadScene(4);
        }
    }
}
