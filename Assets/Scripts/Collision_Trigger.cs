using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision_Trigger : MonoBehaviour
{
    bool trigger_suc=true;
    public GameObject explosion;
    [SerializeField] float wait_time;
    public void OnTriggerEnter(Collider Other)
    {
        GetComponent<Player_Controller>().enabled = false;
        explosion.SetActive(true);
        Invoke("Player_Death_Seq", wait_time);  
    }
    private void Player_Death_Seq()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
