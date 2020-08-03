using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Board : MonoBehaviour
{
    int score=0;
    public Text Text_UI;
    int Score_Per_Hit;
    private void Start()
    {
        Text_UI.text = "Score-"+score.ToString();
           
    }
    public void score_modifier()
    {
        Score_Per_Hit = Random.Range(10, 50);
        score = score + Score_Per_Hit;
        Text_UI.text = "Score-"+score.ToString();
    }

}
