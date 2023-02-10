using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth instance;

    public float maxOxygen = 100.0f;
    public float DecreaseSpeed;
    public float currentOxygen;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentOxygen = maxOxygen;

        if (UIController.instance != null)
        {
            UIController.instance.oxygenLevelSlider.maxValue = maxOxygen;
            UIController.instance.oxygenLevelSlider.value = currentOxygen;
            UIController.instance.oxygenText.text = maxOxygen.ToString() + " / " + currentOxygen.ToString();
        }

    }

    // Update is called once per frame
    void Update()
    {
        currentOxygen -= Time.deltaTime * DecreaseSpeed;


        //print(maxOxygen);

        if (UIController.instance != null)
        {
            UIController.instance.oxygenLevelSlider.value = currentOxygen;
            UIController.instance.oxygenText.text = currentOxygen.ToString() + " / " + maxOxygen.ToString();
        }
        if (currentOxygen <= 0)
        {
            SceneManager.LoadScene("Death_Screen"); ;
        }
    }

    public void healTheAstroPlayer(float oxyHealAmount)
    {
        currentOxygen += oxyHealAmount;

        if (currentOxygen > maxOxygen)
        {
            currentOxygen = maxOxygen;
        }


        UIController.instance.oxygenLevelSlider.value = currentOxygen;
        UIController.instance.oxygenText.text = currentOxygen.ToString() + " / " + maxOxygen.ToString();

    }


}
