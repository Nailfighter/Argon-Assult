using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Game_Data", menuName = "Game_data")]
public class Game_Data : ScriptableObject
{
    public int highscore;
    public bool monochrome = false;
    public bool fps_display = false;
}
