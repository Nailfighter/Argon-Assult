using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Splash_To_Game : MonoBehaviour
{
    [SerializeField] int wait_time=10;
    private void Start()
    {
        Invoke("Load_After_Splash", wait_time);
    }

    private void Load_After_Splash()
    {
        SceneManager.LoadScene(2);
    }
}
