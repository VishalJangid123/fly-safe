using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float cameraSpeed = 5;

    void Update()
    {
        if(Player.startGame == true)
        {
            transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
        }
    }
}
