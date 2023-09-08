using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public static bool isGrounded;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {   // The previous implementation of player character double jump was a buggy mess. This new line of code is the real deal!
        isGrounded = false;
    }
}
