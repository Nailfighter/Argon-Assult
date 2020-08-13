using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Board : MonoBehaviour
{
    public int score=0;
    public Text Text_UI;
    int Score_Per_Hit;
    [SerializeField] Game_Data _data;
    [SerializeField] GameObject FPS_Counter;
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
    private void Update()
    {
        if (score != 0)
        {
            _data.highscore = score;
        }
        FPS_Counter.SetActive(_data.fps_display);

    }

}
