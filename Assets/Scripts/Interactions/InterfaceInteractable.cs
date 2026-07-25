using UnityEngine;
using UnityEngine.Events;

public interface InterfaceInteractable
{
    //protcted is like private but the children can use it too
    public UnityEvent onInteract { get; protected set; }
    public void Interact();
}
