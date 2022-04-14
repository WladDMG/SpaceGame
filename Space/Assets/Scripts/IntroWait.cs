using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class IntroWait : MonoBehaviour
{
    public float tempodeespera = 5f;
    
    void Start()
    {
        StartCoroutine(tempointro());
    }

    IEnumerator tempointro()
    {
        yield return new WaitForSeconds(tempodeespera);
        SceneManager.LoadScene(1);

    }
}
