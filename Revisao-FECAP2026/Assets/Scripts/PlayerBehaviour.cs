using System;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private InputControls inputControls;
    private Vector2 inputDirection => inputControls.Player.Move.ReadValue<Vector2>();
    //private Vector2 InputDirection;

    private void Awake()
    {
        inputControls = new InputControls();
        inputControls.Enable();
        
    }

    private void Update()
    {
        float moveX = inputDirection.x * moveSpeed * Time.deltaTime;
        float moveZ = inputDirection.y * moveSpeed * Time.deltaTime;
        transform.Translate(moveX, 0, moveZ);
    }

    private void OnCollisionEnter(Collision other)
    {
        print("Collided with " + other.transform.name);
    }

    private void OnDestroy()
    {
        inputControls.Disable();
    }

    private void OnDisable()
    {
        inputControls.Disable();
    }
}
