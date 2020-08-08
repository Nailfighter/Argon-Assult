using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class Collision : MonoBehaviour
{
    public bool trigger_suc = true;
    public GameObject explosion;
    [SerializeField] float wait_time;
    [SerializeField] GameObject Life_text;

    public void OnTriggerEnter(Collider Other)
    {
        if(trigger_suc)
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
    }
    private void Player_Death_Seq()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            trigger_suc =! trigger_suc;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Time.timeScale = 2f;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Time.timeScale = 1f;
        }
    }
}

