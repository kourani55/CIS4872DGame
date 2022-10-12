using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player; 

    void Update()
    {
        Vector3 temp = new Vector3(0, 0, 0);
        player.transform.position += temp;
        transform.position = temp;
         

    }
}
