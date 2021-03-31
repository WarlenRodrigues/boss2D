using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public static int TargetsOverTheTable = 0;
    void Start()
    {
        TargetsOverTheTable++;
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("floor"))
        {
            Die();
        }
    }

    private void Die()
    {
        TargetsOverTheTable--;

        if (TargetsOverTheTable <= 0)
            Debug.Log("WON");

        Destroy(gameObject);

    }
}
