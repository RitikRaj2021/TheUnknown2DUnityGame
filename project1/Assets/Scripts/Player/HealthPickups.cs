using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickups : MonoBehaviour
{
    public float oxyHealAmount = 10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerHealth.instance.healTheAstroPlayer(oxyHealAmount);
            Destroy(gameObject);
            //PlayerHealth.instance.healTheAstroPlayer(oxyHealAmount);
        }
    }
}
