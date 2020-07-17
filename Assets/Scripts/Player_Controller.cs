using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class Player_Controller : MonoBehaviour
{
    [Header("Axis")]
    float X_Throw;
    float Y_Throw;
    [Tooltip("In ms^-1")][SerializeField] float Speed=100f;
    [Tooltip("In m")] [SerializeField] int Limit_for_X_offset;
    [Tooltip("In ms^-1")] [SerializeField] float Y_Speed = 100f;
    [Tooltip("In m")] [SerializeField] int Limit_for_Y_offset;


    [Header("Rotaion Factor")]
    [SerializeField] float pitch_factor;
    [SerializeField] float yaw_factor;
    [SerializeField] float roll_factor;
    [SerializeField] float Y_Throw_factor;

    void Update()
    {
        Horizontal_MOV();
        Vertical_MOV();
        Rotation();
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }

     void Horizontal_MOV()
    {
        X_Throw = CrossPlatformInputManager.GetAxis("Horizontal");
        float X_Offset = X_Throw * Speed * Time.deltaTime;
        float raw_X = Mathf.Clamp(transform.localPosition.x + X_Offset, -Limit_for_X_offset, Limit_for_X_offset);
        transform.localPosition = new Vector3(raw_X, transform.localPosition.y, transform.localPosition.z);
    }
    void Vertical_MOV()
    {
        Y_Throw = CrossPlatformInputManager.GetAxis("Vertical");
        float Y_Offset = Y_Throw * Speed * Time.deltaTime;
        float raw_y = Mathf.Clamp(transform.localPosition.y + Y_Offset, -Limit_for_Y_offset, Limit_for_Y_offset);
        transform.localPosition = new Vector3(transform.localPosition.x, raw_y, transform.localPosition.z);
    }
    void Rotation()
    {
        float Pitch =transform.localPosition.y*(-pitch_factor)+Y_Throw*Y_Throw_factor;
        float Yaw = transform.localPosition.x*yaw_factor;
        float Roll =X_Throw * roll_factor;
        transform.localRotation = Quaternion.Euler(Pitch,Yaw,Roll);
    }
}
