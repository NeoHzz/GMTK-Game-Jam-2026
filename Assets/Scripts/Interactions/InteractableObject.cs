using System;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour, InterfaceInteractable
{
    [SerializeField] private UnityEvent _onInteract;
    [SerializeField] private GameObject levelManager;

    UnityEvent InterfaceInteractable.onInteract
    {
        get => _onInteract;
        set => _onInteract = value;
    }

    public void Interact() => _onInteract.Invoke();

    public void BeDestroyed()
    {
        if (this.gameObject.name == "Plant" && GameObject.Find("LevelManager").GetComponent<LevelManager>().gotWater == false)
            return;
        else
            Destroy(this);
    }
}
