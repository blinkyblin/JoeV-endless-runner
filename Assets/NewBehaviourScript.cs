using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int health = 0;

    private int maxHealth = 10;

    int integer = 5;
    float floatNum = 55.5f;
    public bool isPlayerAlive = true;
    string alivemessage = "I am living";
    string deadmessage = "I'm dead just like me inside lol";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(health);
        Debug.Log(maxHealth);

        if (health < maxHealth)
        {
            isPlayerAlive = false;
        }


        if (isPlayerAlive == true)
        {
            Debug.Log(alivemessage);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(health);
        Debug.Log(maxHealth);
    }
}
