using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class Credit_Change : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Invoke("credit_roll_out", 3f);
            other.GetComponent<Player_Controller>().enabled = false;
        }
        void credit_roll_out()
        {
            SceneManager.LoadScene(3);
        }
    }
}