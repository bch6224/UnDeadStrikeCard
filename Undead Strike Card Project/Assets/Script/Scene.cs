using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    private static Scene SceneSingleton;

    public static Scene Instance()
    {
        if(SceneSingleton == null)
        {
            SceneSingleton = new Scene();
        }
        return SceneSingleton;
    }
    /*
    void SingletonTest()
    {
        var x = Instance();
        x.Loading();
    }
    */
    public void Loading()
    {      
        SceneManager.LoadScene(2);
    }

    public void Setting()
    {
        SceneManager.LoadScene(3);
    }
}
