using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class Splash_To_Game : MonoBehaviour
{
    private void Start()
    {
        Invoke("Load_After_Splash", 3f);
    }

    private void Load_After_Splash()
    {
        SceneManager.LoadScene(1);
    }
}
