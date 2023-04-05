using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D playerRigidBody;
    private IInputService inputService;
    public void SetInputService(IInputService _inputService)
    {
        inputService = _inputService;
        inputService.AddObserver(OnInput);
    }
    private void OnInput(Vector2 _direction)
    {
        playerRigidBody.velocity = speed * _direction;
    }
}
