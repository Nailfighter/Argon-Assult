using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music_Controller : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        Invoke("Load_After_Splash",3f);
    }

    private void Load_After_Splash()
    {
        SceneManager.LoadScene(1);
    }
}
