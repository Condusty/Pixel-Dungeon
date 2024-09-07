using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    private int curHealth;

    private void Start()
    {
        curHealth = maxHealth;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            curHealth -= 10;
            Debug.Log(curHealth.ToString());
        }
    }

    public void addLife(int health)
    {
        curHealth += health;
        Debug.Log(curHealth.ToString());
    }
}
