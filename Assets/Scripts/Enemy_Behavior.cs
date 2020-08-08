using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class Enemy_Behavior : MonoBehaviour
{
    [SerializeField] GameObject explosion_prefab;
    [SerializeField] GameObject parent;
    [SerializeField] int health=10;
    public int score_on_hit;
    public int score_on_destruction;
    [SerializeField] bool is_score_hit_on=true;
    private void Start()
    {
        Add_Box_Collision();
    }
    private void OnParticleCollision(GameObject other)
    {
        if (health == 0)
        {
            Kill_Enemy();
        }
        hit_counter();
    }

    private void Kill_Enemy()
    {
        GameObject Enemy_Death = Instantiate(explosion_prefab, transform.position, Quaternion.identity);
        Enemy_Death.transform.parent = parent.transform;
        FindObjectOfType<Score_Board>().score = FindObjectOfType<Score_Board>().score + score_on_destruction;
        Destroy(gameObject);
    }

    void hit_counter()
    {
        if(is_score_hit_on)
        {
            FindObjectOfType<Score_Board>().score_modifier();
            health = health - 1;
        }

    }
    private void Add_Box_Collision()
    {
        Collider Enemy_Collider = gameObject.AddComponent<BoxCollider>();
        Enemy_Collider.isTrigger = false;
    }

}
