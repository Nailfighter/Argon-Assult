using UnityEngine;

public class Missile_Explode : MonoBehaviour
{
    [SerializeField] GameObject explosion_prefab;
    [SerializeField] GameObject text_UI;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag!="enemy" & other.transform.parent!=gameObject.transform.parent)
        {
            Instantiate(explosion_prefab, transform.position+new Vector3(0,0,60f), Quaternion.identity);
            Destroy(gameObject);
        }
    } 
}

