using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    // Start is called before the first frame update

    public void New_Game()
    {
        SceneManager.LoadScene("PrologeScene");
    }

    public void Prolouge()
    {
        SceneManager.LoadScene("PrologeScene");
    }

    public void Level_1()
    {
        SceneManager.LoadScene("L1");
    }

    public void Level_2()
    {
        SceneManager.LoadScene("L2");
    }

    public void Back_to_Menu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void Quit_Game()
    {
        Application.Quit();
    }


}
