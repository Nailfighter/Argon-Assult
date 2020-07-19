using UnityEngine;
using System.Collections;

public class Self_Destruct : MonoBehaviour
{
    public float destroy_time;
    public void Awake()
    {
        Destroy(gameObject, destroy_time);
    }
}
