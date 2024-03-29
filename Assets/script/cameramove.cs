using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class cameramove : MonoBehaviour
{
    public Transform camerapostion;
    private Vector3 pos;
    private Transform playerpostion;
    // Start is called before the first frame update
    void Start()
    {
        playerpostion = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {


       // pos = playerpostion.position + new Vector3((float)0.0, (float)3.6, 0);
        //camerapostion.position = new Vector3(pos.x * 0.0f, pos.y * 1.0f, pos.z * 0.0f);
        if (camerapostion.position.y< 13f)
         {
            pos = playerpostion.position + new Vector3((float)0.0, (float)3.6, 0);
            camerapostion.position = new Vector3(pos.x * 0.0f, pos.y * 1.0f, pos.z * 0.0f);
           // Debug.Log("Camera is following player");
        }
        else if (playerpostion.position.y < 8.3 && camerapostion.position.y == 13f)
        {
            pos = playerpostion.position + new Vector3((float)0.0, (float)3.6, 0);
            camerapostion.position = new Vector3(pos.x * 0.0f, pos.y * 1.0f, pos.z * 0.0f);
           // Debug.Log("player postion is so camera postion to");
        }
        else if (camerapostion.position.y >= 13f)
         {
             camerapostion.position = new Vector3((float)0.0, (float)13.0, 0);
           // Debug.Log("camera postion is fixed");
        }
      

        // camerapostion.position = pos;
    }
   
}
