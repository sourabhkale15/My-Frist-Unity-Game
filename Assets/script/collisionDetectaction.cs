using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class collisionDetectaction : MonoBehaviour
{
    public SpriteRenderer sprite;
    public BoxCollider2D boxco;
    public SpriteRenderer sprite2;
    public BoxCollider2D boxco2;
    public Transform position;

    private void Start()
    {
       // sprite.enabled = false;
       // boxco.enabled = false;
    }
    private void Update()
    {
        if (position.position.y<5)
        {
            sprite.enabled = false;
            boxco.enabled = false;
            sprite2.enabled = false;
            boxco2.enabled = false;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.name == "unitytut-pipe-3")
        {
            sprite.enabled = true;
            boxco.enabled = true;
            sprite2.enabled = true;
            boxco2.enabled = true;
            //Debug.Log("triggerd");
        }
    }

  

}
