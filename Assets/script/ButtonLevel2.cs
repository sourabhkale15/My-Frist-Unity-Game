using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLevel2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void Home()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void ResetSceneLevel2()
    {
        SceneManager.LoadScene("Level-2");
    }
}
