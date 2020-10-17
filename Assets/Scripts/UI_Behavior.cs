using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
public class UI_Behavior : MonoBehaviour
{
    public AudioMixer volume;
    public GameObject input_field;
    [SerializeField] GameObject warning_text;
    [SerializeField] GameObject highscore;
    [SerializeField] Game_Data _Data;
    
    public void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            highscore.GetComponent<Text>().text = _Data.highscore.ToString();
        }
    }
    public void to_htp()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void volume_changer(float level)
    {
        volume.SetFloat("Volume", level);
    }
    public void return_to_menu()
    {
        SceneManager.LoadScene(0);
    }
    
   
}
