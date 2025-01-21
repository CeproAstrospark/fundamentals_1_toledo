using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduction : MonoBehaviour
{
    public int STR;
    public int healthPoints;

    public int Damage;

    // Start is called before the first frame update

    void Start()
    {
        healthPoints = 5 * STR;
        Debug.Log("What's up");
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log("What's up");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage();
        }
        if (healthPoints<0)
        {
            Debug.Log("YOU DIED :D");
        }
    }

    void TakeDamage()
    {

        healthPoints = healthPoints - Damage;
    }
}
    
