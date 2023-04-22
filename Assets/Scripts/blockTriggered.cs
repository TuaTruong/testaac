using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockTriggered : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Object.Destroy(gameObject);
    }
}
