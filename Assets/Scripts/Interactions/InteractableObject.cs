using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour, InterfaceInteractable
{
    [SerializeField] private UnityEvent _onInteract;

    UnityEvent InterfaceInteractable.onInteract
    {
        get => _onInteract;
        set => _onInteract = value;
    }

    public void Interact() => _onInteract.Invoke();
}
