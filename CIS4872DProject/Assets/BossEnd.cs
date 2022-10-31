using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossEnd : MonoBehaviour
{
    public Transform target;
    public GameObject deathMenuUI;
    private void FixedUpdate()
    {
        if(transform.position == target.transform.position)
        {
            deathMenuUI.SetActive(true);
            Time.timeScale = 0f;
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
