using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void Loading()
    {
        SceneManager.LoadScene("Loading");
    }

    public void Setting()
    {
        SceneManager.LoadScene("Setting");
    }
}
