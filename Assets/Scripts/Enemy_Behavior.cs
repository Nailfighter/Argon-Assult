using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class Enemy_Behavior : MonoBehaviour
{
    [SerializeField] GameObject explosion_prefab;
    [SerializeField] GameObject parent;
    [SerializeField] int hits;
    private void Start()
    {
        Add_Box_Collision();
    }
    private void OnParticleCollision(GameObject other)
    {
        if (hits ==0)
        {
            Kill_Enemy();
        }
        hit_counter();
    }

    private void Kill_Enemy()
    {
        GameObject Enemy_Death = Instantiate(explosion_prefab, transform.position, Quaternion.identity);
        Enemy_Death.transform.parent = parent.transform;
        Destroy(gameObject);
    }

    void hit_counter()
    {
        FindObjectOfType<Score_Board>().score_modifier();
        hits--;
    }
    private void Add_Box_Collision()
    {
        Collider Enemy_Collider = gameObject.AddComponent<BoxCollider>();
        Enemy_Collider.isTrigger = false;
    }

}
