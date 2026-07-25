using UnityEngine;

public class EndingStuff : MonoBehaviour
{
    private bool IsTouched = false;

    private void Update()
    {
        if (IsTouched)
            Debug.Log(message: ("touched"));
    }

    public void TouchUpdate()
    {
        IsTouched = true;
    }
}
