using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Application.Quit();
            Debug.Log("Application Closed");
        }
    }
}