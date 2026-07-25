using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{
    [SerializeField] private LayerMask interactableLayer;
    private PlayerInput playerInput;
    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
        playerInput = GetComponent<PlayerInput>();
    }

    private void OnEnable()
    {
        //adds a listener
        playerInput.actions["Interact"].performed += WhenInteract;
    }

    private void OnDisable()
    {
        //removes the listener
        playerInput.actions["Interact"].performed -= WhenInteract;
    }

    private void WhenInteract(InputAction.CallbackContext context)
    {
        //(starting point) position of player + offset by 1 unit up + offset forward so it doesn't collide with player, (direction) forward, reference to hit, length of ray, layer mask
        if (!Physics.Raycast(_transform.position + (Vector3.up * 0.3f) + (_transform.forward * 0.2f), _transform.forward, out var hit, 1.5f, interactableLayer))
            return;

        //checks if we can get the component from the item
        if (!hit.transform.TryGetComponent(out InterfaceInteractable interactable))
            return;

        interactable.Interact();

        Debug.Log(message: ("Interact"));
    }
}
