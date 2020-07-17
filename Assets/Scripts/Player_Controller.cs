using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player_Controller : MonoBehaviour
{
    void Update()
    {
        float Horizontal_Throw = CrossPlatformInputManager.GetAxis("Horizontal");
        print(Horizontal_Throw);
    }
}
