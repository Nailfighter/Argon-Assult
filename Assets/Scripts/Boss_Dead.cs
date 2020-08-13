using UnityEngine;

public class Boss_Dead : MonoBehaviour
{
    [SerializeField] GameObject[] Boss;
    private void OnTriggerEnter(Collider other)
    {
        foreach (GameObject blue in Boss)
        {
            blue.GetComponent<Enemy_Behavior>().Kill_Enemy();
        }
    }
}
