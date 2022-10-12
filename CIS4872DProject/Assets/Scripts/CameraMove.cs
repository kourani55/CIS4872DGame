using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public int speed = 10; 
    private void Update()
    {
        transform.position += Vector3.right * Time.deltaTime * speed;
    }
}
