using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Board : MonoBehaviour
{
    public int score=0;
    public Text Text_UI;
    int Score_Per_Hit;
    private void Start()
    {
        Text_UI.text = score.ToString();
           
    }
    public void score_modifier()
    {
        Score_Per_Hit = FindObjectOfType<Enemy_Behavior>().score_on_hit;
        score = score + Score_Per_Hit;
        Text_UI.text = score.ToString();
    }

}
