using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Caractere
{
    private void /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coletavel"))
        {
            collision.gameObject.SetActive(false);
        }
    }
}
