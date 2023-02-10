using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public void back_To_Main()
    {
        SceneManager.LoadScene("Main_Menu");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit_Game()
    {
        Application.Quit();
    }
}
