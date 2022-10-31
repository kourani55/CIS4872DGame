using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public GameObject deathMenuUI;
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Destroy(other.gameObject);
        // SceneManager.LoadScene(0);
        deathMenuUI.SetActive(true);
        Time.timeScale = 0f;

    }
   
    
}
