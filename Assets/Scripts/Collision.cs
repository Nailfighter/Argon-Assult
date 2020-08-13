using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;
using UnityStandardAssets.CrossPlatformInput;

public class Collision : MonoBehaviour
{
    public GameObject explosion;
    [SerializeField] float wait_time;
    [SerializeField] GameObject Life_text;
    [SerializeField] GameObject pause;
    bool is_pause_on = false;
    [SerializeField] PlayableDirector Main_Timeline;
    [SerializeField] Game_Data _data;

    public void FixedUpdate()
    {
        if (FindObjectOfType<Life_Counter>().Life <= 0)
        {
            GetComponent<Player_Controller>().enabled = false;
            explosion.SetActive(true);
            Invoke("Player_Death_Seq", wait_time);
        }

    }
    public void OnTriggerEnter(Collider Other)
    {
        if (FindObjectOfType<Life_Counter>().Life<=0)
        {
            GetComponent<Player_Controller>().enabled = false;
            explosion.SetActive(true);
            Invoke("Player_Death_Seq", wait_time);
        }
        if (Other.tag =="Missile")
        {
            FindObjectOfType<Life_Counter>().life_reduction_by_missile();
        }
        else
        {
            FindObjectOfType<Life_Counter>().life_counter();
        }
    }
    private void Player_Death_Seq()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            is_pause_on = !is_pause_on;
            if (is_pause_on)
            {
                Time.timeScale = 0f;
                pause.SetActive(true);
                FindObjectOfType<Player_Controller>().enabled = false;
            }
            else
            {
                Time.timeScale = 1f;
                pause.SetActive(false);
                FindObjectOfType<Player_Controller>().enabled =true;
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

