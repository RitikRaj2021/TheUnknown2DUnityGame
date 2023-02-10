using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerScript : MonoBehaviour
{
    public static LevelManagerScript instance;
    public int currentGold;

    public int currentHealth;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        UIController.instance.CoinText.text = currentGold.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AcquireGold(int amount)
    {
        currentGold += amount;

        UIController.instance.CoinText.text = currentGold.ToString();
    }

    public void healTheAstroPlayer(int amount)
    {
        currentHealth += amount;
    }



}
