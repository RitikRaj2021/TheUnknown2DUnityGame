using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsMenu : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadScene("L1");
    }
}
