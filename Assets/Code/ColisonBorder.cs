using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisonBorder : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.TryGetComponent(out PlayerMovement playerMovement))
        {
            rigidbody.gravityScale = 1;
        }
    }
}
