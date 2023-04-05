using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DependencyService : MonoBehaviour
{
    [SerializeField] private PCInputService inputService;
    [SerializeField] private PlayerMovement playerMovement;
    private void Awake()
    {
        playerMovement.SetInputService(inputService);
    }
}
