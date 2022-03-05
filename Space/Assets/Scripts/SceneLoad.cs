using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{

    public void Load1()
    {
        if (JobCounter.contador >= 3)
        {
            SceneManager.LoadScene(1);
        }
    }
    public void Load2()
    {
        if (JobCounter.contador >= 3)
        {
            SceneManager.LoadScene(2);
        }
    }
    public void Load3()
    {
        if (JobCounter.contador >= 3)
        {
            SceneManager.LoadScene(3);
        }
    }
}
