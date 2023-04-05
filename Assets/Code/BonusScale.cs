using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusScale : MonoBehaviour
{
    [SerializeField] private float scaleAndMassValue = 2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.TryGetComponent(out PlayerMovement playerMovement))
        {
            playerMovement.transform.DOScale(scaleAndMassValue, 1);
            playerMovement.GetComponent<Rigidbody2D>().mass = scaleAndMassValue;
            Destroy(gameObject);
        }
    }

}
