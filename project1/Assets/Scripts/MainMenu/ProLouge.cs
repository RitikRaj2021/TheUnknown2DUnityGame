using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProLouge : MonoBehaviour
{
    public void Play_Game()
    {
        SceneManager.LoadScene("ControlsMenu");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
