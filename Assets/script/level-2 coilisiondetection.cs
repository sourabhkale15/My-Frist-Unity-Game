using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.PlayerSettings;

public class leveltwocollisionDetectaction : MonoBehaviour
{
  

    private void Start()
    {
       // sprite.enabled = false;
       // boxco.enabled = false;
    }
   
   

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "unitytut-pipe-4")
        {
            SceneManager.LoadScene("SampleScene");

           
        }
    }
}
