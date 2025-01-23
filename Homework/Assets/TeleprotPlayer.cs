using UnityEngine;
using UnityEngine.InputSystem;

public class TeleprotPlayer : MonoBehaviour
{
    public InputActionReference action;
    public Transform externalViewPoint;
    private Vector3 startPosition;
    private bool isOut = false;
    void Start()
    {
        action.action.Enable();
        action.action.performed += SwitchPosition;
        startPosition = transform.position;
    }

    private void SwitchPosition(InputAction.CallbackContext ctx)
    {
        if(isOut)
        {
            transform.position = externalViewPoint.position;
        }
        else
        {
            transform.position = startPosition;
        }
        isOut = !isOut;
    }
}
