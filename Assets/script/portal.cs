using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portal : MonoBehaviour
{
    public SpriteRenderer sprite;
    public AudioSource soundfordoorappearing;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name== "portal door")
        {
            Debug.Log("col 2");
            //SceneManager.LoadScene("Level-2");
            SceneManager.LoadSceneAsync("Level-2");
            soundfordoorappearing.enabled = false;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "detection for door") 
        {
            Debug.Log("col 1");
            sprite.enabled = true;
        // GetComponent<AudioSource>().enabled = true;
        soundfordoorappearing.enabled = true;
        }

        else if (collision.gameObject.name == "coilder for distored world")
        {
            Debug.Log("player coilded");
            SceneManager.LoadSceneAsync("distortion world");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "detection for door")
        {
            sprite.enabled = false;
            soundfordoorappearing.enabled = false;
        }
    }




}
