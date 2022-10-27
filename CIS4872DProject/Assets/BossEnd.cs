using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossEnd : MonoBehaviour
{
    public Transform target;
    private void FixedUpdate()
    {
        if(transform.position == target.transform.position)
        {
            SceneManager.LoadScene(0); 
        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        SceneManager.LoadScene(0);
    //    }
    //}
}
